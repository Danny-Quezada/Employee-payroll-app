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
            return Math.Round(SalarioTrabajadores * InatecDeduccion, 3);
        }

        public decimal CalculateInssPatronal(decimal Salary, int CantidadTrabajadores)
        {
            if (CantidadTrabajadores < 50)
            {
                return Math.Round(Salary * InssPatronal[0], 3);
            }
            else if (CantidadTrabajadores >= 50)
            {
                return Math.Round(Salary * InssPatronal[1], 3);
            }
            return 0;
        }
    }
}
