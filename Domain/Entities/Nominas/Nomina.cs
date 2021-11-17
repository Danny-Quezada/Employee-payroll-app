using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Empleados;
using Domain.Enums;

namespace Domain.Entities.Nominas
{
    public class Nomina
    {
        public int Id { get; set; }
        public EmpleadoDgv[] Empleados { get; set; }
        public Meses Mes { get; set; }
        public int Año { get; set; }
       
        public int TotalEmpleados => Empleados.Length; 
        
        public decimal TotalNomina => Empleados.Sum(x => x.Neto_A_Recibir + x.Aguinaldo + x.INSS_Patronal + x.Vacaciones + x.Indemnizacion + x.INATEC);
    }
}
