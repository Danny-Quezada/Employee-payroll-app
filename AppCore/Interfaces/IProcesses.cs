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
        decimal PagoPrestamo(decimal Salary, decimal Prestamo);
        decimal CalculateHorasExtras(int HorasExtras, decimal Salary);
        decimal CalculateAguinaldo(decimal Salary, int MesesTrabjados);
        decimal CalculateIndemnizacion(int MesesTrabajados);
    }
}
