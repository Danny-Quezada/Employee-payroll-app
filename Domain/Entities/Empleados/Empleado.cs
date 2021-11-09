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
		public decimal Prestamo { get; set; }
		public int MesesPrestamo { get; set; }
		public int MesesTrabajadosAguinaldo { get; set; }
		public int MesesTrabajadosIndemnizacion { get; set; }
		public int AñosTrabajadosIndemnizacion { get; set; }
		public int MesesTrabajadosVacaciones { get; set; }
		public Empleado(string nombreCompleto, Remuneraciones rem, string codINSS)
        {
			NombreCompleto = nombreCompleto;
			Remuneraciones = rem;
			CodigoINSS = codINSS;
			
			Estado = EstadoTrabajador.Activo;
        }
	}
}
