using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IProcessesEmpleado
    {
        decimal CalculateIR(decimal Salary);
        decimal CalculateInss(decimal Salary);
        decimal CalculateHorasExtras(int HorasExtras, decimal Salary);
        decimal CalculateAguinaldo(decimal Salary, int MesesTrabajados);
        decimal CalculateIndemnizacion(decimal salary, int MesesTrabajados, int AñosTrabajados);
        decimal CalculateVacations(int MesesTrabajados, decimal salary, EstadoTrabajador estadoTrabajador);
    }
}
