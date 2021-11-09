using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Interfaces
{
    public interface IProcesses
    {
        decimal CalculateIR(decimal Salary);
        decimal CalculateInss(decimal Salary);
        decimal CalculateHorasExtras(int HorasExtras, decimal Salary);
        decimal CalculateAguinaldo(decimal Salary, int MesesTrabjados);
        decimal CalculateIndemnizacion(decimal salary, int MesesTrabajados, int AñosTrabajados);
        decimal CalculateVacations(int MesesTrabajados, decimal salary, EstadoTrabajador estadoTrabajador);
    }
}
