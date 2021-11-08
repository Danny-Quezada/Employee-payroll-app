using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCore.Interfaces;
using AppCore.Services;
using Domain.Entities.Empleados;
using Domain.Enums;
using Domain.Interfaces;
using Infraestructure.Repository;

namespace Infraestructure.EmpleadosRepos
{
    //TODO: Hice otro findAll() que reciba int para devolver los empleados o los despedidos
    public class EmpleadoListRepository : BaseRepository<Empleado>, IEmpleadoRepository
    {
        //private List<Empleado> empleados;
        private List<Empleado> empleadosDespedidos;
        private List<Empleado> despedidosDelMes;
        private IProcesses processes;
        private IEmpresaService empresaService;
        public EmpleadoListRepository(IProcesses processes, IEmpresaService empresaService)
        {
            this.processes = processes;
            this.empresaService = empresaService;
            //empleados = new List<Empleado>();
            empleadosDespedidos = new List<Empleado>();
            despedidosDelMes = new List<Empleado>();
        }

        public void AumentarAntiguedad()
        {
            //TODO: En este metodo se aumentaran los meses trabajados (se puede crear una propiedad de eso)del empleado,
            //se le debe agregar logica de acuerdo a lo que se necesite. Luego de eso se lo debe de mandar a llamar
            //en em frmPrincipal en el evento del boton siguiente, luego de la linea que manda a llamar al metodo
            //quitar despedidos del mes
        }

        public int CalculoFactoy(EmpleadoDgv empleadoDgv)
        {
            return empleadoDgv.Cuota_Prestamo > 0 ? 0 : 1;
        }
        public bool Delete(Empleado t)
        {
            if (t is null)
            {
                throw new ArgumentNullException(nameof(t));
            }
            if (datos.Count ==0)
            {
                throw new ArgumentException("No hay empleados para despedir");
            }
            return datos.Remove(t);
        }
        public bool Despedir(int id)
        {
            Empleado e = GetEmpleadoById(id);
            if (e == null)
            {
                throw new ArgumentException($"No se pudo despedir al empleado con id: {id}");
            }
            bool exitoso = Delete(e);
            e.Estado = EstadoTrabajador.Inactivo;
            despedidosDelMes.Add(e);
            empleadosDespedidos.Add(e);
            return exitoso;
        }

        public ICollection<Empleado> FindAll(int tipo)
        {
            switch (tipo)
            {
                case 1:
                    return FindAll();
                case 2:
                    return despedidosDelMes;
                case 3:
                    List<Empleado> temp = new List<Empleado>(datos);
                    temp.AddRange(despedidosDelMes);
                    //Con la siguiente linea ya se ponen ordenados
                    ICollection<Empleado> temp2=temp.OrderBy(x => x.Id).ToList();
                    return temp2;
                default:
                    return null;
            }
        }

        public Empleado GetEmpleadoById(int id)
        {
            return GetEmpleadoById(datos, id);
        }

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

        public override int GetLastId()
        {
            Empleado Tmp;
            Empleado Tmp1;
            if (datos.Count == 0 && empleadosDespedidos.Count == 0)
            {
                return 0;
            }
            if (empleadosDespedidos.Count == 0)
            {
                Tmp = datos.FindLast(O => O.Id > 0);
                return Tmp.Id;
            }
            if (datos.Count == 0)
            {
                Tmp1 = empleadosDespedidos.FindLast(O => O.Id > 0);
                return Tmp1.Id;
            }
            Tmp = datos.FindLast(O => O.Id > 0);
            Tmp1 = empleadosDespedidos.FindLast(O => O.Id > 0);
            return Tmp.Id > Tmp1.Id ? Tmp.Id : Tmp1.Id;
        }
        //TODO: Mejorar este metodo
        public EmpleadoDgv GetResumenEmpleado(int id)
        {
            Empleado[] Trabajadores = FindAll(3).ToArray();

            //TODO: No es necesario hacer esto porque el valor del INATEC no lo tiene que tener cada trabajador
            decimal SalarioTrabajadores = 0;

            foreach (Empleado a in Trabajadores)
                SalarioTrabajadores += a.Remuneraciones.SalarioBase;


            Empleado e = GetEmpleadoById(Trabajadores,id);
            if (e == null)
            {
                throw new ArgumentException($"No se puede dar un resumen del empleado con id: {id}");
            }
            e.Remuneraciones.TotalIngresos = e.Remuneraciones.SalarioBase + processes.CalculateHorasExtras(e.Remuneraciones.HorasExtras, e.Remuneraciones.SalarioBase);
            EmpleadoDgv empleadoDgv = new EmpleadoDgv()
            {
                Cargo = e.Cargos,
                Id = e.Id,
                Nombre_Completo = e.NombreCompleto,
                CodigoINSS = e.CodigoINSS,
                Salario_Mensual = e.Remuneraciones.SalarioBase,
                Horas_Extras = e.Remuneraciones.HorasExtras,
                Ingreso_Horas_Extras = processes.CalculateHorasExtras(e.Remuneraciones.HorasExtras, e.Remuneraciones.SalarioBase),
                INSS_Laboral = processes.CalculateInss(e.Remuneraciones.TotalIngresos),
                IR = processes.CalculateIR(e.Remuneraciones.SalarioBase),
                INSS_Patronal = empresaService.CalculateInssPatronal(e.Remuneraciones.TotalIngresos, datos.Count),
                Aguinaldo = processes.CalculateAguinaldo(e.Remuneraciones.SalarioBase, e.MesesTrabajadosAguinaldo),
                Indemnizacion = processes.CalculateIndemnizacion(e.MesesTrabajadosIndemnizacion),
                
                //TODO: el calculo del INATEC lo tienen todos los empleados
                INATEC = empresaService.CalculateInatec(SalarioTrabajadores),
                
                Cuota_Prestamo = 0,
                Vacaciones = 0,
                Estado = e.Estado
            };
            return empleadoDgv;
        }
        //TODO: Mejorar este método
        public EmpleadoDgv[] GetResumenEmpleados()
        {
            if (FindAll(3).Count==0)
            {
                return null;
            }
            EmpleadoDgv[] empleadosDgv = new EmpleadoDgv[FindAll(3).Count];
            int i = 0;
            foreach (Empleado e in FindAll(3))
            {
                empleadosDgv[i] = GetResumenEmpleado(e.Id);
                i++;
            }
            return empleadosDgv;
        }
        public void QuitarDespedidos(Empleado e)
        {
            if (datos.Count==0)
            {
                throw new ArgumentException("No se puede quitar a los despedidos porque no hay empleados");
            }
            e.Estado = EstadoTrabajador.Activo;
            datos.Add(e);
            empleadosDespedidos.Remove(e);
        }

        public void QuitarDespedidosDelMes()
        {
            despedidosDelMes.Clear();
        }

        public int Update(Empleado t)
        {
            if (t is null)
            {
                throw new ArgumentNullException(nameof(t));
            }
            if (datos.Count==0)
            {
                throw new ArgumentException("No hay empleados");
            }
            int index= datos.FindIndex(p=>p.Id==t.Id);
            if (index < 0)
            {
                throw new ArgumentException($"El empleado con Id {t.Id} no se encuentra");
            }
            datos[index] = t;
            return index;
        }
    }
}
