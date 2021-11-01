using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IProcessesEmpresa
    {
        decimal CalculateInatec(decimal SalarioTrabajadores);
        decimal CalculateInssPatronal(decimal Salary, int CantidadTrabajadores);
    }
}
