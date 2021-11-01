using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Interfaces
{
    public interface IEmpresaService
    {
        decimal CalculateInatec(decimal SalarioTrabajadores);
        decimal CalculateInssPatronal(decimal Salary, int CantidadTrabajadores);
    }
}
