using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCore.Interfaces;
using Domain.Entities.Empleados;
using Domain.Enums;
using Domain.Interfaces;
using MongoDB.Driver;

namespace Infraestructure.MongoRepository
{
    public class EmpleadosMongoRepository : MongoBaseRepository<Empleado>, IEmpleadoRepository
    {
        private IMongoCollection<Empleado> empleadosDespedidos;
        private IMongoCollection<Empleado> despedidosDelMes;
        private IProcesses processes;
        private IEmpresaService empresaService;

        public EmpleadosMongoRepository(IProcesses processes, IEmpresaService empresaService) : base("Empleados")
        {
            empleadosDespedidos = db.GetCollection<Empleado>("EmpleadosDespedidos");
            despedidosDelMes = db.GetCollection<Empleado>("DespedidosDelMes");
            this.processes = processes;
            this.empresaService = empresaService;
        }
        //TODO: No creo que funcione este metodo
        public void AumentarAntiguedad(Meses meses)
        {
            List<Empleado> empleados = (List<Empleado>)FindAll(1);
            foreach (Empleado a in empleados)
            {
                //le agregue esta linea, verificar si funciona bien
                a.MesesTrabajados++;
                if (a.Vacaciones.MesesTrabajadosVacaciones == 6)
                {
                    a.Vacaciones.MesesTrabajadosVacaciones = 1;
                }
                else
                {
                    a.Vacaciones.MesesTrabajadosVacaciones += 1;
                }
                if (meses == Meses.Enero)
                {
                    a.Aguinaldo.MesesTrabajadosAguinaldo = 1;
                }
                else
                {
                    a.Aguinaldo.MesesTrabajadosAguinaldo += 1;
                }

                if (a.Indemnizacion.MesesTrabajadosIndemnizacion == 12)
                {
                    a.Indemnizacion.MesesTrabajadosIndemnizacion = 1;
                    a.Indemnizacion.AñosTrabajadosIndemnizacion += 1;
                }
                else
                {
                    a.Indemnizacion.MesesTrabajadosIndemnizacion += 1;
                }

                if (a.Prestamo.MesesPrestamo == 0)
                {
                    a.Prestamo.Cuota_Prestamo = 0;
                }
                else
                {
                    a.Prestamo.MesesPrestamo -= 1;
                }
                Update(a, 1);
            }
        }

        public bool Delete(Empleado t)
        {
            return Delete(t, collection);
        }

        public bool Despedir(int id)
        {
            Empleado e = GetEmpleadoById(id);
            if (e == null)
            {
                throw new ArgumentException($"No se pudo despedir al empleado con id: {id}");
            }
            e.Estado = EstadoTrabajador.Inactivo;
            //esta linea la agregue
            e.MesesTrabajados = 1;
            Update(e, 1);
            bool exitoso = Delete(e);
            Add(despedidosDelMes, e);
            Add(empleadosDespedidos, e);
            return exitoso;
        }

        public ICollection<Empleado> FindAll(int tipo)
        {
            switch (tipo)
            {
                case 1:
                    return FindAll();
                case 2:
                    return empleadosDespedidos.Find(x => true).ToList();
                case 3:
                    List<Empleado> temp = new List<Empleado>(FindAll());
                    temp.AddRange(FindAll(4));
                    //Con la siguiente linea ya se ponen ordenados
                    ICollection<Empleado> temp2 = temp.OrderBy(x => x.Id).ToList();
                    return temp2;
                case 4:
                    return despedidosDelMes.Find(x => true).ToList();
                default:
                    throw new ArgumentException("No coloco una opcion valida");
            }
        }

        public Empleado GetEmpleadoById(int id)
        {
            return GetEmpleadoById(FindAll(), id);
        }
        //TODO: Este metodo deberia cambiar para recibir un IMongoCollection por
        //lo que podria pasar a ser privado, de todas maneras en el list repository
        //solo se ocupa pocas veces, aunque creo que de igual manera no afectaria mucho
        public Empleado GetEmpleadoById(ICollection<Empleado> empleados, int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException($"El id {id} es invalido");
            }
            if (empleados.Count == 0)
            {
                throw new ArgumentException("No hay empleados");
            }
            return empleados.ToList().Find(p => p.Id == id);
        }

        public EmpleadoDgv GetResumenEmpleado(int id, int mes)
        {
            Empleado[] Trabajadores = FindAll(3).ToArray();

            //TODO: No es necesario hacer esto porque el valor del INATEC no lo tiene que tener cada trabajador
            decimal SalarioTrabajadores = 0;

            foreach (Empleado a in Trabajadores)
                SalarioTrabajadores += a.Remuneraciones.SalarioBase;


            Empleado e = GetEmpleadoById(Trabajadores, id);
            if (e == null)
            {
                throw new ArgumentException($"No se puede dar un resumen del empleado con id: {id}");
            }
            HacerCalculos(e, mes);
            EmpleadoDgv empleadoDgv = new EmpleadoDgv()
            {
                Cargo = e.Cargos,
                Id = e.Id,
                Nombre_Completo = e.NombreCompleto,
                CodigoINSS = e.CodigoINSS,
                Salario_Mensual = e.Remuneraciones.SalarioBase,
                Horas_Extras = e.Remuneraciones.HorasExtras,
                Ingreso_Horas_Extras = e.Remuneraciones.IngresoHorasExtras,
                INSS_Laboral = e.Deducciones.INSSLaboral,
                IR = e.Deducciones.IR,
                //TODO: se usa datos.count es decir los empleados activos, no los que estan en la nomina
                INSS_Patronal = empresaService.CalculateInssPatronal(e.Remuneraciones.TotalIngresos, FindAll().Count),
                //TODO: el calculo del INATEC lo tienen todos los empleados
                INATEC = empresaService.CalculateInatec(SalarioTrabajadores),
                Cuota_Prestamo = e.Prestamo.Cuota_Prestamo,
                Vacaciones = e.Vacaciones.VacacionesPago,
                Estado = e.Estado,
                Aguinaldo = e.Aguinaldo.AguinaldoPago,
                Indemnizacion = e.Indemnizacion.IndemnizacionPago
            };
            empleadoDgv.Neto_A_Recibir = empleadoDgv.Total_Ingresos - empleadoDgv.Total_Deducciones + empleadoDgv.Vacaciones + empleadoDgv.Indemnizacion + empleadoDgv.Aguinaldo - e.PagoPendiente;
            if (empleadoDgv.Neto_A_Recibir < 0)
            {
                e.PagoPendiente = Math.Abs(empleadoDgv.Neto_A_Recibir);
                empleadoDgv.Neto_A_Recibir = 0;
            }
            return empleadoDgv;
        }

        public EmpleadoDgv[] GetResumenEmpleados(int mes)
        {
            //TODO: modifique todos los findAll sueltos y los almacene en empleados
            var empleados = FindAll(3);
            if (empleados.Count == 0)
            {
                return null;
            }
            EmpleadoDgv[] empleadosDgv = new EmpleadoDgv[empleados.Count];
            int i = 0;
            foreach (Empleado e in empleados)
            {
                empleadosDgv[i] = GetResumenEmpleado(e.Id, mes);
                i++;
            }
            return empleadosDgv;
        }

        public void QuitarDespedidos(Empleado empleado, int i)
        {
            if (i == 1)
            {
                empleado.Estado = EstadoTrabajador.Activo;
                Create(empleado);
                Delete(empleado, empleadosDespedidos);
            }
            else if (i == 2)
            {
                empleado.Estado = EstadoTrabajador.Activo;
                Delete(empleado, despedidosDelMes);
            }
        }

        public void QuitarDespedidosDelMes()
        {
            if (FindAll(4).Count > 0)
            {
                despedidosDelMes.DeleteMany(x => true);
            }
        }
        //Se puede hacer void el Update
        public int Update(Empleado t, int i)
        {
            if (t is null)
            {
                throw new ArgumentNullException(nameof(t));
            }
            if (i == 1)
            {
                if (FindAll(1).Count == 0)
                {
                    throw new ArgumentException("No hay empleados");
                }
                Update(collection, t);
                //return index;
            }
            else if (i == 2)
            {
                if (FindAll(2).Count == 0)
                {
                    throw new ArgumentException("No hay despedidos");
                }
                Update(empleadosDespedidos, t);
                //return index;
            }
            else if (i == 3)
            {
                if (FindAll(4).Count == 0)
                {
                    throw new ArgumentException("No hay despedidos");
                }
                Update(despedidosDelMes, t);
                //return index;
            }
            return 0;
        }
        public override int GetLastId()
        {
            int idActivos = base.GetLastId();
            int idDespedidos;
            var datos = FindAll(2).ToList();
            if (datos.Count == 0)
            {
                idDespedidos = 0;
            }
            else
            {
                try
                {
                    idDespedidos = (int)datos[datos.Count - 1].GetType().GetProperty("Id").GetValue(datos[datos.Count - 1]);
                }
                catch (Exception)
                {
                    throw new ArgumentException("El objeto no posee la propiedad Id");
                }
            }
            return (idActivos > idDespedidos) ? idActivos : idDespedidos;
        }
        //metodo para que entre con todos los datos calculados a la base de datos,
        //probar si se tiene que pasar por referencia el empleado
        private void HacerCalculos(Empleado e, int mes)
        {
            if (e == null)
            {
                throw new ArgumentException($"El empleado es nulo");
            }
            e.Remuneraciones.TotalIngresos = e.Remuneraciones.SalarioBase + processes.CalculateHorasExtras(e.Remuneraciones.HorasExtras, e.Remuneraciones.SalarioBase);
            e.Deducciones.INSSLaboral = processes.CalculateInss(e.Remuneraciones.TotalIngresos);
            e.Deducciones.IR = processes.CalculateIR(e.Remuneraciones.SalarioBase);
            e.Remuneraciones.IngresoHorasExtras = processes.CalculateHorasExtras(e.Remuneraciones.HorasExtras, e.Remuneraciones.SalarioBase);
            if (e.Estado == EstadoTrabajador.Inactivo && e.Prestamo.Cuota_Prestamo > 0)
            {
                e.Prestamo.Cuota_Prestamo = e.Prestamo.Cuota_Prestamo * e.Prestamo.MesesPrestamo;
                e.Prestamo.MesesPrestamo = 0;
            }
            if ((Meses)mes == Meses.Diciembre)
            {
                e.Aguinaldo.AguinaldoPago = processes.CalculateAguinaldo(e.Remuneraciones.SalarioBase, e.Aguinaldo.MesesTrabajadosAguinaldo);
            }
            if (e.Estado == EstadoTrabajador.Inactivo)
            {
                e.Indemnizacion.IndemnizacionPago = processes.CalculateIndemnizacion(e.Remuneraciones.SalarioBase, e.Indemnizacion.MesesTrabajadosIndemnizacion, e.Indemnizacion.AñosTrabajadosIndemnizacion);
            }
            e.Vacaciones.VacacionesPago = processes.CalculateVacations(e.Vacaciones.MesesTrabajadosVacaciones, e.Remuneraciones.SalarioBase, e.Estado);
        }
        //metodo que elimine a empleados de una coleccion especificada
        private bool Delete(Empleado t, IMongoCollection<Empleado> coleccion)
        {
            //creo que no es necesario poner un try catch
            try
            {
                var filter = Builders<Empleado>.Filter.Eq("Id", t.Id);
                var emp = coleccion.FindOneAndDelete(filter);
                if (emp == null)
                {
                    throw new Exception();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void Add(IMongoCollection<Empleado> coleccion, Empleado empleado)
        {
            coleccion.InsertOne(empleado);
        }
        private void Update(IMongoCollection<Empleado> coleccion, Empleado e)
        {
            try
            {
                //con replace da errores
                var filter = Builders<Empleado>.Filter.Eq("Id", e.Id);
                //buscar la manera de que actualizar no sea tan largo

                var updateFilter = Builders<Empleado>.Update.Set("NombreCompleto", e.NombreCompleto).Set("CodigoINSS", e.CodigoINSS).Set("Deducciones", e.Deducciones)
                    .Set("Imagen", e.Imagen).Set("Remuneraciones", e.Remuneraciones).Set("Cargos", e.Cargos).Set("Estado", e.Estado).Set("Cedula", e.Cedula)
                    .Set("Prestamo", e.Prestamo).Set("Aguinaldo", e.Aguinaldo).Set("Indemnizacion", e.Indemnizacion).Set("Vacaciones", e.Vacaciones)
                    .Set("PagoPendiente", e.PagoPendiente).Set("MesesTrabajados", e.MesesTrabajados).Set("CorreoELectronico", e.CorreoELectronico).Set("Numero",e.Numero);
                var emp = coleccion.FindOneAndUpdate(filter, updateFilter);
                if (emp == null)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                throw new ArgumentException($"No se ha podido actualizar al empleado con Id {e.Id}");
            }
        }
    }
}
