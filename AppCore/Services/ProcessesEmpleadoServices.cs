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
        public decimal CalculateHorasExtras(int HorasExtras, decimal Salary)
        {
            return processesEmpleado.CalculateHorasExtras(HorasExtras, Salary);
        }

        public decimal CalculateInss(decimal Salary)
        {
            return processesEmpleado.CalculateInss(Salary);
        }

        public decimal CalculateIR(decimal Salary)
        {
            return processesEmpleado.CalculateIR(Salary);
        }

        public decimal PagoPrestamo(decimal Salary)
        {
            return processesEmpleado.PagoPrestamo(Salary);
        }
    }
}
