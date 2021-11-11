using Domain.Enums;
using Domain.Enums.CargosEmpleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Empleados
{
	public class Empleado
	{
		public byte[] Imagen { get; set; }
		public string NombreCompleto { get; set; }
		public int Id { get; set; }
		public string CodigoINSS { get; set; }
		public Deducciones Deducciones { get; set; }
		public Remuneraciones Remuneraciones { get; set; }
		public Cargos Cargos { get; set; }
		public EstadoTrabajador Estado { get; set; }
		public Prestamo Prestamo { get; set; }
		public Aguinaldo Aguinaldo { get; set; }
		public Indemnizacion Indemnizacion { get; set; }
		public Vacaciones Vacaciones { get; set; }
		public decimal PagoPendiente { get; set; }
		public Empleado(string nombreCompleto, Remuneraciones rem, string codINSS, Deducciones deducciones, Aguinaldo aguinaldo, Indemnizacion indemnizacion, Prestamo prestamo, Vacaciones vacaciones)
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
		}
	}
}
