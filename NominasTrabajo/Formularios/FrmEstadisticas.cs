using AppCore.Interfaces;
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
		public Nomina Nomina;
		private INominaService NominaService;
		int Despedidos = 0;
		public FrmEstadisticas(Nomina nomina)
		{
			this.Nomina = nomina;
			InitializeComponent();
		}
		public FrmEstadisticas(INominaService nominaService)
		{
			this.NominaService = nominaService;
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

			if (NominaService == null)
			{
				NominaIndividual();
			}
			else if (Nomina == null)
			{
				Nominas();
			}
		}
		private void Nominas()
		{
			gunaChart2.XAxes.Display = false;
			var Nominas = NominaService.FindAll();

			lblInformacion.Text = $"Nóminas totales: {Nominas.Count}";
			lblEmpleados.Text = $"         {Nominas.Max(x => x.TotalEmpleados)}";
			decimal Total = Math.Round(Nominas.Sum(x => x.TotalNomina));
			var ListaEmpleadosGlobal = Nominas.Select(x => x.Empleados).ToArray();
			for (int i = 0; i < ListaEmpleadosGlobal.Length; i++)
			{
				Despedidos += ListaEmpleadosGlobal[i].Count(x => x.Estado == Domain.Enums.EstadoTrabajador.Inactivo);

			}
			lblDespedidos.Text = $"       {Despedidos}";
			lblNomina.Text = $" {Total}";
			foreach (Nomina n in Nominas)
			{

				gunaPieDataset1.DataPoints.Add($"Nomina { n.Mes.ToString()}", Convert.ToDouble(n.TotalNomina));
			}

			var dataset1 = new Guna.Charts.WinForms.GunaStackedHorizontalBarDataset();
			dataset1.Label = "Empleados despedidos";
			for (int i = 0; i < ListaEmpleadosGlobal.Length; i++)
			{
				Despedidos = ListaEmpleadosGlobal[i].Count(x => x.Estado == Domain.Enums.EstadoTrabajador.Inactivo);
				dataset1.DataPoints.Add("Empleados despedidos", Despedidos);
			}

			var dataset2 = new Guna.Charts.WinForms.GunaStackedHorizontalBarDataset();

			dataset2.Label = "Empleados contratados";
			foreach (Nomina n in Nominas)
			{
				dataset2.DataPoints.Add("Empleados contratados", Convert.ToDouble(n.Empleados.Length));
			}
			dataset2.FillColors = Guna.Charts.WinForms.ChartUtils.RandomColors(3);
			gunaChart2.Datasets.Add(dataset1);
			gunaChart2.Datasets.Add(dataset2);
		}
		private void NominaIndividual()
		{

			lblInformacion.Text = $"Nómina del mes de {Nomina.Mes} del año {Nomina.Año}";
			lblEmpleados.Text = $"         {Nomina.TotalEmpleados}";
			decimal Total = Math.Round(Nomina.TotalNomina);

			for (int i = 0; i < Nomina.Empleados.Length; i++)
			{
				if (Nomina.Empleados[i].Estado == Domain.Enums.EstadoTrabajador.Inactivo)
				{
					Despedidos++;
				}
			}
			lblNomina.Text = $"   {Total}";
			lblDespedidos.Text = $"          {Despedidos}";
			gunaPieDataset1.DataPoints.Add("Empleados Contratados", Nomina.TotalEmpleados);
			gunaChart1.Legend.Position = Guna.Charts.WinForms.LegendPosition.Right;
			gunaPieDataset1.DataPoints.Add("Empleados Despedidos", Despedidos);
			//Creando grafica de barra del Salario base y sus SalarioTotal.
			var Empleados = Nomina.Empleados;

			var dataset2 = new Guna.Charts.WinForms.GunaStackedHorizontalBarDataset();
			var dataset1 = new Guna.Charts.WinForms.GunaStackedHorizontalBarDataset();
			for (int i=0; i<Empleados.Length; i++)
			{
				dataset2.DataPoints.Add(Empleados[i].Nombre_Completo, Convert.ToDouble(Empleados[i].Salario_Mensual));
				dataset2.Label = "Salario Base";
				dataset1.DataPoints.Add(Empleados[i].Nombre_Completo, Convert.ToDouble(Empleados[i].Total_Ingresos));
				dataset1.Label = "Sueldo total";
				
			}
			gunaChart2.XAxes.Display = false;
			dataset1.FillColors = Guna.Charts.WinForms.ChartUtils.RandomColors(Nomina.TotalEmpleados,222);
			gunaChart2.Datasets.Add(dataset2);
			gunaChart2.Datasets.Add(dataset1);

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

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void pictureBox6_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
	}
}
