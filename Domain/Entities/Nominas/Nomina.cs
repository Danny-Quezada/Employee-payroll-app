using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Empleados;
using Domain.Enums;
using MongoDB.Bson.Serialization.Attributes;

namespace Domain.Entities.Nominas
{
    public class Nomina
    {
       
        public int Id { get; set; }
        [BsonElement("Empleado")]
        public EmpleadoDgv[] Empleados { get; set; }
        [BsonElement("Mes")]
        public Meses Mes { get; set; }
        [BsonElement("Año")]
        public int Año { get; set; }
        [BsonElement("TotalEmpleados")]
        public int TotalEmpleados => Empleados.Length;
        [BsonElement("TotalNomina")]
        public decimal TotalNomina => Empleados.Sum(x => x.Neto_A_Recibir + x.Aguinaldo + x.INSS_Patronal + x.Vacaciones + x.Indemnizacion + x.INATEC);
    }
}
