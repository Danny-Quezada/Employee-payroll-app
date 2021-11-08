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
        //TODO: aqui faltaria añadirle la sumatoria de otras cosas que paga la empresa
        public decimal TotalNomina => Empleados.Sum(x => x.Total_Deducciones + x.Total_Ingresos);
    }
}
