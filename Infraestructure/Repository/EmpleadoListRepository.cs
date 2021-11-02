using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Empleados;
using Domain.Enums;
using Domain.Interfaces;

namespace Infraestructure.EmpleadosRepos
{
    public class EmpleadoListRepository : IEmpleadoRepository
    {
        private List<Empleado> empleados;
        private List<Empleado> empleadosDespedidos;
        public EmpleadoListRepository()
        {
            empleados = new List<Empleado>();
            empleadosDespedidos = new List<Empleado>();
        }
        public void Create(Empleado t)
        {
            if (t is null)
            {
                throw new ArgumentNullException(nameof(t));
            }

            empleados.Add(t);
        }

        public bool Delete(Empleado t)
        {
            if (t is null)
            {
                throw new ArgumentNullException(nameof(t));
            }
            if (empleados == null)
            {
                throw new ArgumentException("No hay empleados");
            }
            return empleados.Remove(t);
        }

        public void Despedir(int id)
        {
            Empleado e = GetEmpleadoById(id);
            if (e == null)
            {
                throw new ArgumentException($"No se pudo despedir al empleado con id: {id}");
            }
            empleados.Remove(e);
            empleadosDespedidos.Add(e);
            e.Estado = EstadoTrabajador.Inactivo;
        }

        public Empleado[] FindAll()
        {
            return empleados.ToArray();
        }

        public Empleado GetEmpleadoById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException($"El id {id} es invalido");
            }
            if (empleados == null)
            {
                throw new ArgumentException("No hay empleados");
            }
            return empleados.Find(p=>p.Id==id);
        }

        public int GetLastId()
        {
            Empleado Tmp = empleados.FindLast(O => O.Id > 0);
            Empleado Tmp1 = empleadosDespedidos.FindLast(O => O.Id > 0);
            if (Tmp == null && Tmp1 == null)
            {
                return 0;
            }
            if (Tmp == null)
            {
                return Tmp1.Id;
            }
            if (Tmp1 == null)
            {
                return Tmp.Id;
            }
            return Tmp.Id > Tmp1.Id ? Tmp.Id : Tmp1.Id;
        }
        //TODO: Mejorar este metodo
        public EmpleadoDgv GetResumenEmpleado(int id)
        {
            Empleado e = GetEmpleadoById(id);
            if (e == null)
            {
                throw new ArgumentException($"No se puede dar un resumen del empleado con id: {id}");
            }
            EmpleadoDgv empleadoDgv = new EmpleadoDgv()
            {
                Cargo = e.Cargos,
                Id = e.Id,
                Nombre_Completo = e.NombreCompleto,
                CodigoINSS = e.CodigoINSS,
                Salario_Mensual = e.Remuneraciones.SalarioBase,
                Horas_Extras = e.Remuneraciones.HorasExtras,
                Ingreso_Horas_Extras = e.Remuneraciones.IngresoHorasExtras,
                Total_Ingresos = e.Remuneraciones.TotalIngresos,
                INSS_Laboral = 0,
                IR = 0,
                Total_Deducciones = 0,
                INSS_Patronal = 0,
                Aguinaldo=0,
                Indemnizacion=0,
                INATEC=0,
                Prestamos=0,
                Vacaciones=0,
                //INSS_Laboral=e.Deducciones.INSSLaboral,
                //IR=e.Deducciones.IR,
                //Total_Deducciones=e.Deducciones.TotalDeducciones,
                //Neto_A_Recibir=e.Deducciones.SalarioNeto
            };
            return empleadoDgv;
        }
        //TODO: Mejorar este método
        public EmpleadoDgv[] GetResumenEmpleados()
        {
            if (empleados == null)
            {
                throw new ArgumentException("No hay empleados para dar resumen");
            }
            EmpleadoDgv[] empleadosDgv = new EmpleadoDgv[empleados.Count];
            int i = 0;
            foreach (Empleado e in empleados)
            {
                empleadosDgv[i] = new EmpleadoDgv()
                {
                    Cargo = e.Cargos,
                    Id = e.Id,
                    Nombre_Completo = e.NombreCompleto,
                    CodigoINSS = e.CodigoINSS,
                    Salario_Mensual = e.Remuneraciones.SalarioBase,
                    Horas_Extras = e.Remuneraciones.HorasExtras,
                    Ingreso_Horas_Extras = e.Remuneraciones.IngresoHorasExtras,
                    Total_Ingresos = e.Remuneraciones.TotalIngresos,
                    //INSS_Laboral = e.Deducciones.INSSLaboral,
                    //IR = e.Deducciones.IR,
                    //Total_Deducciones = e.Deducciones.TotalDeducciones,
                    //Neto_A_Recibir = e.Deducciones.SalarioNeto
                    INSS_Laboral = 0,
                    IR = 0,
                    Total_Deducciones = 0,
                    INSS_Patronal = 0,
                    Aguinaldo = 0,
                    Indemnizacion = 0,
                    INATEC = 0,
                    Prestamos = 0,
                    Vacaciones = 0,
                };
                i++;
            }
            return empleadosDgv;
        }
        public void QuitarDespedidos(Empleado e)
        {
        if (empleados == null)
        {
            throw new ArgumentException("No se puede quitar a los despedidos porque no hay empleados");
        }
        e.Estado = EstadoTrabajador.Activo;
        empleados.Add(e);
        empleadosDespedidos.Remove(e);
    }

        public int Update(Empleado t)
        {
            if (t is null)
            {
                throw new ArgumentNullException(nameof(t));
            }
            if (empleados == null)
            {
                throw new ArgumentException("No hay empleados");
            }
            int index= empleados.FindIndex(p=>p.Id==t.Id);
            if (index < 0)
            {
                throw new ArgumentException($"El empleado con Id {t.Id} no se encuentra");
            }
            empleados[index] = t;
            return index;
        }
    }
}
