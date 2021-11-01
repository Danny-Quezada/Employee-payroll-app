using AppCore.Interfaces;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    public class ProcessesEmpresaServices : IEmpresaService
    {
        private IProcessesEmpresa processesEmpresa;
        public decimal CalculateInatec(decimal SalarioTrabajadores)
        {
            return processesEmpresa.CalculateInatec(SalarioTrabajadores);
        }

        public decimal CalculateInssPatronal(decimal Salary, int CantidadTrabajadores)
        {
            return processesEmpresa.CalculateInssPatronal(Salary, CantidadTrabajadores);
        }
    }
}
