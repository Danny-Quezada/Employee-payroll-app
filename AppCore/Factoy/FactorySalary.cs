using AppCore.Interfaces;
using AppCore.Processes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Factoy
{
    public static class FactorySalary
    {
        public static ISalary CreateMethod(ISalary e) 
        {
            if (e is SalaryCalculatorWithLoan)
            {
                return new SalaryCalculatorWithLoan();
            }
            else if (e is SalaryCalculatorWithoutLoan)
            {
                return new SalaryCalculatorWithoutLoan();
            }
            throw new Exception();
        }
    }
}
