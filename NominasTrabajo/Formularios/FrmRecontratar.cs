using AppCore.Interfaces;
using Domain.Entities.Empleados;
using Domain.Enums.FiltrosDAta;
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
	public partial class FrmRecontratar : Form
	{
		public int seleccion = 0;
		public IEmpleadoService Despedidos { get; set; }
		public FrmRecontratar()
		{
			InitializeComponent();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Close();
		}


		private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				seleccion = e.RowIndex;
				btnModificar.Visible = true;
				btnRecontratar.Visible = true;
			}
			else
			{
				btnRecontratar.Visible = false;
				btnModificar.Visible = false;
			}
		}
		
		private void FrmRecontratar_Load(object sender, EventArgs e)
		{
			guna2ComboBox1.Items.AddRange(Enum.GetValues(typeof(FiltrosData)).Cast<object>().ToArray());
			RellenarDgv();
		}
		public void RellenarDgv()
		{
			guna2DataGridView1.Rows.Clear();
			var despedidos = (List<Empleado>)Despedidos.FindAll(2);
			for (int i = 0; i < despedidos.Count; i++)
			{
				guna2DataGridView1.Rows.Add(despedidos[i].Id, despedidos[i].CodigoINSS, despedidos[i].NombreCompleto, despedidos[i].Cargos, despedidos[i].Remuneraciones.SalarioBase);
			}
			if (guna2DataGridView1.Rows.Count <= 0)
			{
				btnModificar.Visible = false;
				btnRecontratar.Visible = false;
			}
		}
		private void btnRecontratar_Click(object sender, EventArgs e)
		{
			int a = Convert.ToInt32(guna2DataGridView1.Rows[seleccion].Cells[0].Value);

			Empleado Recontratatado = Despedidos.GetEmpleadoById(Despedidos.FindAll(2),a);
			Despedidos.QuitarDespedidos(Recontratatado,1);
		
			RellenarDgv();
			var empleados = Despedidos.FindAll(1);
			List<Empleado> empleadosDespedidos = (List<Empleado>)Despedidos.FindAll(4);
			int index = empleadosDespedidos.FindIndex(p => p.Id == Recontratatado.Id);
			if (index >= 0)
			{
				Despedidos.Update(Recontratatado, 3);
				Despedidos.QuitarDespedidos(Recontratatado, 2);
			}
			
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			int a = Convert.ToInt32(guna2DataGridView1.Rows[seleccion].Cells[0].Value);
			Empleado Recontratatado = Despedidos.GetEmpleadoById(Despedidos.FindAll(2), a);
			FrmEditarEmpleado editarEmpleado = new FrmEditarEmpleado();
			editarEmpleado.emp = Recontratatado;
			editarEmpleado.a = 2;
			editarEmpleado.empleadoService = Despedidos;
			editarEmpleado.ShowDialog();
			RellenarDgv();
		}
		private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			var a = (FiltrosData)guna2ComboBox1.SelectedIndex;
			txtBuscar.PlaceholderText = $"{a.ToString()}";
			txtBuscar.Visible = true;
		}

		private void txtBuscar__TextChanged(object sender, EventArgs e)
		{
			
		}

		private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
		{
		
		}
		private void Filtrar(Func<Empleado,bool> a,ref List<Empleado> despedidos)
		{
			despedidos = (List<Empleado>)Despedidos.FindAll(2);
			List<Empleado> despedidoSeleccionado = (List<Empleado>)despedidos.Where(a).ToList();
			if (despedidoSeleccionado.Count == 0)
			{
				return;
			}
			guna2DataGridView1.Rows.Clear();
			for (int i = 0; i < despedidoSeleccionado.Count; i++)
			{
				guna2DataGridView1.Rows.Add(despedidoSeleccionado[i].Id, despedidoSeleccionado[i].CodigoINSS, despedidoSeleccionado[i].NombreCompleto, despedidoSeleccionado[i].Cargos, despedidoSeleccionado[i].Remuneraciones.SalarioBase);
			}
			if (guna2DataGridView1.Rows.Count <= 0)
			{
				btnModificar.Visible = false;
				btnRecontratar.Visible = false;
			}
		}
		private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (guna2ComboBox1.SelectedIndex == 0)
			{
				if (char.IsDigit(e.KeyChar))
				{
					e.Handled=true;
				}

			}
			else if (guna2ComboBox1.SelectedIndex == 1 || guna2ComboBox1.SelectedIndex == 2)
			{
				if (char.IsLetter(e.KeyChar))
				{
					e.Handled = true;
				}
			}
			
		}

		private void guna2GradientButton1_Click(object sender, EventArgs e)
		{
			List<Empleado> empleados = new List<Empleado>();
			if (guna2ComboBox1.SelectedIndex == 0)
			{
				Filtrar(x => x.NombreCompleto == txtBuscar.Texts, ref empleados);
			}
			else if(guna2ComboBox1.SelectedIndex == 1|| guna2ComboBox1.SelectedIndex == 2)
			{
				Filtrar(x => x.Id == Convert.ToInt32(txtBuscar.Texts) || x.Remuneraciones.SalarioBase==Convert.ToDecimal(txtBuscar.Texts) , ref empleados);
			}

		}

		private void guna2DataGridView1_DoubleClick(object sender, EventArgs e)
		{
			RellenarDgv();
		}
	}
}
