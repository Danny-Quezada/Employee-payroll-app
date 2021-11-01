using Domain.Entities.Empleados;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class ProcessesEmpleadosRepository : IProcessesEmpleado
    {
        private decimal InssDedudccion => 0.07M;
        private TarifaIR[] tarifaIRs = new TarifaIR[]
        {
            new TarifaIR(){Desde = 0.01M, Hasta=100000,ImpuestoBase = 0, PorcentajeAplicable = 0, SobreExceso = 0},
            new TarifaIR(){Desde = 100000.01M, Hasta = 200000,ImpuestoBase = 0, PorcentajeAplicable = 0.15M, SobreExceso = 100000},
            new TarifaIR(){Desde = 200000.01M, Hasta = 350000,ImpuestoBase = 15000, PorcentajeAplicable = 0.20M, SobreExceso = 200000},
            new TarifaIR(){Desde = 350000.01M, Hasta = 500000,ImpuestoBase = 45000, PorcentajeAplicable = 0.25M, SobreExceso = 350000},
            new TarifaIR(){Desde = 500000.01M, Hasta = 10000000,ImpuestoBase = 87500, PorcentajeAplicable = 0.30M, SobreExceso = 500000},
        };
        public decimal CalculateHorasExtras(int HorasExtras, decimal Salary)
        {
            decimal SalaryPerHour = 2 * (Salary / 240);
            return SalaryPerHour * HorasExtras;
        }

        public decimal CalculateInss(decimal Salary)
        {
            return Salary * InssDedudccion;
        }

        public decimal CalculateIR(decimal Salary)
        {
            decimal SalarioAnual = Salary * 12, ir = 0;
            foreach (TarifaIR tarifaIR in tarifaIRs)
            {
                if ((SalarioAnual - tarifaIR.Desde) * (tarifaIR.Hasta - SalarioAnual) >= 0)
                {
                    ir = ((((SalarioAnual - tarifaIR.SobreExceso) * tarifaIR.PorcentajeAplicable) + tarifaIR.ImpuestoBase) / 12);
                    break;
                }
            }
            return ir;
        }

        public decimal PagoPrestamo(decimal Salary)
        {
            //Se deberia de cambiar la logica
            return 0;
        }
    }
}
