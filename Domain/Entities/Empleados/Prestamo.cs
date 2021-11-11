using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Empleados
{
    public class Prestamo
    {
        public decimal Cuota_Prestamo { get; set; }
        public int MesesPrestamo { get; set; }
    }
}
