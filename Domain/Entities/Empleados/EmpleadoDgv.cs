using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;
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
        public decimal Total_Ingresos => Salario_Mensual + Ingreso_Horas_Extras;
        public decimal INSS_Laboral { get; set; }
        public decimal IR { get; set; }
        public decimal Total_Deducciones => INSS_Laboral + IR + Cuota_Prestamo;
        public decimal Neto_A_Recibir { get; set; }
        public decimal INSS_Patronal { get; set; }
        //TODO: no deberia de tener la propiedad INATEC porque no se ocupa en el datagridview
        public decimal INATEC { get; set; }
        public decimal Aguinaldo { get; set; }
        public decimal Indemnizacion { get; set; }
        public decimal Vacaciones { get; set; }
        public decimal Cuota_Prestamo { get; set; }
        public EstadoTrabajador Estado { get; set; }
    }
}
