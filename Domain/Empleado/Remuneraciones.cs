using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Empleado
{
	public class Remuneraciones
	{
		public decimal SalarioBase { get; set; }
		public int HorasExtras { get; set; }
		public decimal IngresoHorasExtras { get; set; }
		public decimal TotalIngresos { get; set; }

	}
}
