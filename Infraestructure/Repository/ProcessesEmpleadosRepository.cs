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

        public decimal CalculateAguinaldo(decimal Salary, int MesesTrabajados)
        {
            return (Salary / 12) * MesesTrabajados;
        }

        public decimal CalculateIndemnizacion(decimal salary, int MesesTrabajados, int AñosTrabajados)
        {
            if (AñosTrabajados <= 3)
            {
                decimal SalaryWithYear = salary * AñosTrabajados;
                decimal SalaryProportionalWithMonth = (salary * (MesesTrabajados * 30)) / 360;
                return SalaryWithYear + SalaryProportionalWithMonth;
            }
            else if (AñosTrabajados > 3)
            {
                int AñosTemp = AñosTrabajados - 3;

                decimal SalaryWithYear = salary * 3;
                decimal SalaryPerDay = salary / 30;
                decimal SalaryWithMoreYear = SalaryPerDay * (20 * AñosTemp);
                decimal SalaryProportionalWithMonth = SalaryPerDay * (((MesesTrabajados * 30) * 20) / 360);
                return SalaryWithYear + SalaryWithMoreYear + SalaryProportionalWithMonth;
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
                    return 15 * SalaryPerDay;
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
                return SalaryPerDay * dias;
            }
            return 0;
        }
    }
}
