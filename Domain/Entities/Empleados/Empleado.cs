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
		public int HorasTrabajadas { get; set; }
		public int Id { get; set; }
		public string CodigoINSS { get; set; }
		public Deducciones Deducciones { get; set; }
		public Remuneraciones Remuneraciones { get; set; }
		public Cargos Cargos { get; set; }
		public EstadoTrabajador Estado { get; set; }

		public Empleado(string nombreCompleto, Remuneraciones rem, string codINSS, int hrs)
        {
			NombreCompleto = nombreCompleto;
			Remuneraciones = rem;
			CodigoINSS = codINSS;
			HorasTrabajadas = hrs;
			Estado = EstadoTrabajador.Activo;
        }
	}
}
