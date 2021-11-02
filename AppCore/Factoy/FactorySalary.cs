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
        public static ISalary CreateMethod(IProcesses processes, int factory) 
        {
            if (factory == 0)
            {
                return new SalaryCalculatorWithLoan();
            }
            else if (factory == 1)
            {
              //  return new SalaryCalculatorWithoutLoan();
            }
            throw new Exception();
        }
    }
}
