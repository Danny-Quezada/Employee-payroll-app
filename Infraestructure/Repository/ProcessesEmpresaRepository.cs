using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class ProcessesEmpresaRepository : IProcessesEmpresa
    {
        private decimal InatecDeduccion => 0.02M;
        private decimal[] InssPatronal = new decimal[]
        {
        0.215M,
        0.225M
        };
        public decimal CalculateInatec(decimal SalarioTrabajadores)
        {
            return SalarioTrabajadores * InatecDeduccion;
        }

        public decimal CalculateInssPatronal(decimal Salary, int CantidadTrabajadores)
        {
            if (CantidadTrabajadores < 50)
            {
                return Salary * InssPatronal[1];
            }
            else if (CantidadTrabajadores >= 50)
            {
                return Salary * InssPatronal[2];
            }
            return 0;
        }
    }
}
