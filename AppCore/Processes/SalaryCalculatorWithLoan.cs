using AppCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Processes
{
    public class SalaryCalculatorWithLoan : ISalary
    {
        public SalaryCalculatorWithLoan(decimal PaymentMonth)
        {
            this.PaymentMonth = PaymentMonth;
        }
        public SalaryCalculatorWithLoan()
        {

        }

        private decimal PaymentMonth;
        private IProcesses Processes;
        private decimal PaymentLoan(decimal Salary, decimal PaymenMonth)
        {
            return Salary - PaymenMonth;
        }
        protected override decimal CalculateSalary(decimal Salary)
        {
            decimal ir = Processes.CalculateIR(Salary), Inss =
                Processes.CalculateInss(Salary);
            return Salary - ir - Inss - PaymentMonth;
        }
    }
}
