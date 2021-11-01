using AppCore.Interfaces;
using Domain.Entities.Empleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Processes
{
    public class SalaryCalculatorWithoutLoan : ISalary
    {
        private IProcesses Processes;
        protected override decimal CalculateSalary(decimal Salary)
        {
            decimal ir = Processes.CalculateIR(Salary), Inss =
                Processes.CalculateInss(Salary);
            return Salary - ir - Inss;
        }
    }
}
