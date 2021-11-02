using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Interfaces
{
    public abstract class ISalary
    {
        public abstract decimal CalculateSalary(decimal Salary, decimal PaymentMonth);
    }
}
