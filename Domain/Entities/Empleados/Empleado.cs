using Domain.Enums;
using Domain.Enums.CargosEmpleados;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Empleados
{
	public class Empleado
	{
		[BsonElement("Imagen")]
		public byte[] Imagen { get; set; }
		[BsonElement("NombreCompleto")]
		public string NombreCompleto { get; set; }
		[BsonElement("Id")]
		public int Id { get; set; }
		[BsonElement("Cedula")]
		public string Cedula { get; set; }
		[BsonElement("CodigoINSS")]
		public string CodigoINSS { get; set; }
		[BsonElement("Deducciones")]
		public Deducciones Deducciones { get; set; }
		[BsonElement("Remuneraciones")]
		public Remuneraciones Remuneraciones { get; set; }
		[BsonElement("Cargos")]
		public Cargos Cargos { get; set; }
		[BsonElement("Estado")]
		public EstadoTrabajador Estado { get; set; }
		[BsonElement("Prestamo")]
		public Prestamo Prestamo { get; set; }
		[BsonElement("Aguinaldo")]
		public Aguinaldo Aguinaldo { get; set; }
		[BsonElement("Indemnizacion")]
		public Indemnizacion Indemnizacion { get; set; }
		[BsonElement("Vacaciones")]
		public Vacaciones Vacaciones { get; set; }
		[BsonElement("PagoPendiente")]
		public decimal PagoPendiente { get; set; }
		[BsonElement("MesesTrabajados")]
		public int MesesTrabajados { get; set; }
		[BsonElement("Numero")]
		public string Numero { get; set; }
		[BsonElement("CorreoELectronico")]
		public string CorreoELectronico { get; set; }
		public Empleado(string nombreCompleto, Remuneraciones rem, string codINSS, Deducciones deducciones, Aguinaldo aguinaldo, Indemnizacion indemnizacion, Prestamo prestamo, Vacaciones vacaciones, string numero, string correo, string cedula)
		{
			NombreCompleto = nombreCompleto;
			Remuneraciones = rem;
			CodigoINSS = codINSS;
			Deducciones = deducciones;
			Estado = EstadoTrabajador.Activo;
			Aguinaldo = aguinaldo;
			Indemnizacion = indemnizacion;
			Prestamo = prestamo;
			Vacaciones = vacaciones;
			MesesTrabajados = 1;
			Numero = numero;
			CorreoELectronico = correo;
			Cedula = cedula;
		}
	}
}
