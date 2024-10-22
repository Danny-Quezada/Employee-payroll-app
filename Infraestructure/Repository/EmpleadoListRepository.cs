﻿using System;
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

        public void AumentarAntiguedad(Meses meses)
        {
            List<Empleado> empleados = (List<Empleado>)FindAll(1);
            foreach (Empleado a in empleados)
            {
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
            }
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

            e.MesesTrabajados = 1;

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
                    return empleadosDespedidos; 
                case 3:
                    List<Empleado> temp = new List<Empleado>(datos);
                    temp.AddRange(despedidosDelMes);
                    //Con la siguiente linea ya se ponen ordenados
                    ICollection<Empleado> temp2=temp.OrderBy(x => x.Id).ToList();
                    return temp2;
                case 4:
                    return despedidosDelMes;
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
                INSS_Patronal = empresaService.CalculateInssPatronal(e.Remuneraciones.TotalIngresos, datos.Count),
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
        //TODO: Mejorar este método
        public EmpleadoDgv[] GetResumenEmpleados(int mes)
        {
            if (FindAll(3).Count==0)
            {
                return null;
            }
            EmpleadoDgv[] empleadosDgv = new EmpleadoDgv[FindAll(3).Count];
            int i = 0;
            foreach (Empleado e in FindAll(3))
            {
                empleadosDgv[i] = GetResumenEmpleado(e.Id, mes);
                i++;
            }
            return empleadosDgv;
        }
        public void QuitarDespedidos(Empleado e, int i)
        {
			//if (datos.Count==0)
			//{
			//    throw new ArgumentException("No se puede quitar a los despedidos porque no hay empleados");
			//}
			if (i == 1)
			{
                e.Estado = EstadoTrabajador.Activo;
                datos.Add(e);
                empleadosDespedidos.Remove(e);
            }
           else if (i == 2)
			{
                e.Estado = EstadoTrabajador.Activo;
                despedidosDelMes.Remove(e);
			}
        }

        public void QuitarDespedidosDelMes()
        {
		
                despedidosDelMes.Clear();
        
        }

        public int Update(Empleado t,int i)
        {
            if (t is null)
            {
                throw new ArgumentNullException(nameof(t));
            }
            if (i == 1)
            {
                if (datos.Count == 0)
                {
                    throw new ArgumentException("No hay empleados");
                }
                int index = datos.FindIndex(p => p.Id == t.Id);
                if (index < 0)
                {
                    throw new ArgumentException($"El empleado con Id {t.Id} no se encuentra");
                }
                datos[index] = t;
                return index;
            }
            else if (i == 2)
			{
				if (empleadosDespedidos.Count == 0)
				{
                    throw new ArgumentException("No hay despedidos");
				}
                int index = empleadosDespedidos.FindIndex(p => p.Id == t.Id);
				if (index < 0)
				{
                    throw new ArgumentException($"El empleado con Id {t.Id} no se encuentra");
                }
                empleadosDespedidos[index] = t;
                return index;
			}
            else if (i == 3)
			{
				if (despedidosDelMes.Count == 0)
				{
                    throw new ArgumentException("No hay despedidos");
				}
                int index = despedidosDelMes.FindIndex(p => p.Id == t.Id);
                if (index < 0)
                {
                    throw new ArgumentException($"El empleado con Id {t.Id} no se encuentra");
                }
                despedidosDelMes[index] = t;
                return index;
            }

            return 0;
        }
    }
}
