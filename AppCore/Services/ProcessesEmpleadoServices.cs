using AppCore.Interfaces;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    public class ProcessesEmpleadoServices : IProcesses
    {
        private IProcessesEmpleado processesEmpleado;

        public ProcessesEmpleadoServices(IProcessesEmpleado processesEmpleado)
        {
            this.processesEmpleado = processesEmpleado;
        }

        public decimal CalculateAguinaldo(decimal Salary, int MesesTrabajados)
        {
            return processesEmpleado.CalculateAguinaldo(Salary, MesesTrabajados);
        }

        public decimal CalculateHorasExtras(int HorasExtras, decimal Salary)
        {
            return processesEmpleado.CalculateHorasExtras(HorasExtras, Salary);
        }

        public decimal CalculateIndemnizacion(int MesesTrabajados)
        {
            return processesEmpleado.CalculateIndemnizacion(MesesTrabajados);
        }

        public decimal CalculateInss(decimal Salary)
        {
            return processesEmpleado.CalculateInss(Salary);
        }

        public decimal CalculateIR(decimal Salary)
        {
            return processesEmpleado.CalculateIR(Salary);
        }

        public decimal PagoPrestamo(decimal Salary, decimal Prestamo)
        {
            return processesEmpleado.PagoPrestamo(Salary, Prestamo);
        }
    }
}
