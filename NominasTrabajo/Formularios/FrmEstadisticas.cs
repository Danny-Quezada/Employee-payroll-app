using Domain.Entities.Nominas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NominasTrabajo.Formularios
{
	public partial class FrmEstadisticas : Form
	{
		public Nomina Nomina { get; set; }
		int Despedidos = 0;
		public FrmEstadisticas()
		{
			InitializeComponent();
		}

		private void gunaChart1_Load(object sender, EventArgs e)
		{

		}

		private void gunaChart2_Load(object sender, EventArgs e)
		{

		}
		
		private void FrmEstadisticas_Load(object sender, EventArgs e)
		{
			
			lblInformacion.Text = $"Nómina del mes de {Nomina.Mes} del año {Nomina.Año}";
			lblEmpleados.Text = $"         {Nomina.TotalEmpleados}";
			decimal Total = Math.Round(Nomina.TotalNomina);
			
			for(int i=0; i<Nomina.Empleados.Length; i++)
			{
				if (Nomina.Empleados[i].Estado ==Domain.Enums.EstadoTrabajador.Inactivo)
				{
					Despedidos++;
				}
			}
			lblNomina.Text = $"   {Total}";
			lblDespedidos.Text = $"          {Despedidos}";
			gunaPieDataset1.DataPoints.Add("Empleados Contratados", Nomina.TotalEmpleados);
			gunaChart1.Legend.Position = Guna.Charts.WinForms.LegendPosition.Right;
			gunaPieDataset1.DataPoints.Add("Empleados Despedidos", Despedidos);

			var dataset1 = new Guna.Charts.WinForms.GunaStackedHorizontalBarDataset();
			dataset1.DataPoints.Add("Empleados contratados", Nomina.TotalEmpleados);
			dataset1.FillColors = Guna.Charts.WinForms.ChartUtils.RandomColors(Nomina.TotalEmpleados);
			gunaChart2.Datasets.Add(dataset1);
			var dataset2 = new Guna.Charts.WinForms.GunaStackedHorizontalBarDataset();
			dataset2.DataPoints.Add("Empleados despedidos", Despedidos);
			dataset2.FillColors = Guna.Charts.WinForms.ChartUtils.RandomColors(Nomina.TotalEmpleados);	
			gunaChart2.Datasets.Add(dataset2);
	
		
		}

		private void gunaChart1_Load_1(object sender, EventArgs e)
		{

		}

		private void guna2Panel3_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
