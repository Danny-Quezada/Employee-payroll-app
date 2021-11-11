using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Empleados
{
    public class Indemnizacion
    {
        public decimal IndemnizacionPago { get; set; }
        public int MesesTrabajadosIndemnizacion { get; set; }
        public int AñosTrabajadosIndemnizacion { get; set; }
    }
}
