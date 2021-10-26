using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Empleado
{
	public class Deducciones
	{
		public decimal INSSLaboral = 0.7M;
		public decimal SalarioNeto { get; set; }

		public decimal TotalDeducciones { get; set; }

		public decimal IR = 0.15M;





	}
}
