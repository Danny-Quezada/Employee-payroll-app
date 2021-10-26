using Domain.Empleado.CargosEmpleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Empleado
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

	}
}
