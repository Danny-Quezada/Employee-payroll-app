using Domain.Entities.Empleados;
using Domain.Enums;
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
            return Math.Round(SalaryPerHour * HorasExtras,3);
        }

        public decimal CalculateInss(decimal Salary)
        {
            return Math.Round(Salary * InssDedudccion,3);
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
            return Math.Round(ir,3);
        }

        public decimal CalculateAguinaldo(decimal Salary, int MesesTrabajados)
        {
            return Math.Round((Salary / 12) * MesesTrabajados,3);
        }

        public decimal CalculateIndemnizacion(decimal salary, int MesesTrabajados, int AñosTrabajados)
        {
            if (AñosTrabajados <= 3)
            {
                decimal SalaryWithYear = salary * AñosTrabajados;
                decimal SalaryProportionalWithMonth = (salary * (MesesTrabajados * 30)) / 365;
                return Math.Round(SalaryWithYear + SalaryProportionalWithMonth,3);
            }
            else if (AñosTrabajados > 3)
            {
                //Parte de Kevin
                if (AñosTrabajados > 6)
                {
                    AñosTrabajados = 6;
                }

                int AñosTemp = AñosTrabajados - 3;

                decimal SalaryWithYear = salary * 3;
                decimal SalaryPerDay = salary / 30;
                decimal SalaryWithMoreYear = SalaryPerDay * (20 * AñosTemp);
                decimal SalaryProportionalWithMonth = SalaryPerDay * (((MesesTrabajados * 30) * 20) / 365);
                return Math.Round(SalaryWithYear + SalaryWithMoreYear + SalaryProportionalWithMonth, 3);
            }
            return 0;
        }

        public decimal CalculateVacations(int MesesTrabajados, decimal salary, EstadoTrabajador estadoTrabajador)
        {
            if (estadoTrabajador == EstadoTrabajador.Activo)
            {
                if (MesesTrabajados == 6)
                {
                    decimal SalaryPerDay = salary / 30;
                    return Math.Round(15 * SalaryPerDay, 3);
                }
                else
                {
                    return 0;
                }
            }
            else if (estadoTrabajador == EstadoTrabajador.Inactivo)
            {
                decimal dias = ((decimal)(2.5 * MesesTrabajados));
                decimal SalaryPerDay = salary / 30;
                return Math.Round(SalaryPerDay * dias, 3);
            }
            return 0;
        }
    }
}
