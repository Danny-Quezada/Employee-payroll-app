using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums.CargosEmpleados;

namespace Domain.Entities.Empleados
{
    public class EmpleadoDgv
    {
        public int Id { get; set; }
        public string CodigoINSS { get; set; }
        public string Nombre_Completo { get; set; }
        public Cargos Cargo { get; set; }
        public decimal Salario_Mensual { get; set; }
        public int Horas_Extras { get; set; }
        public decimal Ingreso_Horas_Extras { get; set; }
        public decimal Total_Ingresos { get; set; }
        public decimal INSS_Laboral { get; set; }
        public decimal IR { get; set; }
        public decimal Total_Deducciones { get; set; }
        public decimal Neto_A_Recibir => Total_Ingresos - Total_Deducciones;
    }
}
