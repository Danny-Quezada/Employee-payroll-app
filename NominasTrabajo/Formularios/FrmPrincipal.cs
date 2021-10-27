using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCore.Interfaces;

namespace NominasTrabajo

{
	
	public partial class FrmPrincipal : Form
	{
		private int n= 0;
		public IEmpleadoService empleadoService { get; set; }
		public IEmpleadoService despedidos { get; set; }
		public FrmPrincipal()
		{
			InitializeComponent();
		}

		private void FrmPrincipal_Load(object sender, EventArgs e)
		{
			//guna2DataGridView1.Rows.Add("1","333-333","Danny Alejandro Quezada Cruz",22222,"Gerente General",22,3333,333,33,222222,323233,5555);
			//guna2DataGridView1.Rows.Add("2", "Josue");
		}

		

		private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				n = e.RowIndex;
				btnModificar.Visible = true;
				btnEliminar.Visible = true;
			}
			else
			{
				btnModificar.Visible = false;
				btnEliminar.Visible = false;
			}
		}

		private void pbExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void pbExit_MouseDown(object sender, MouseEventArgs e)
		{
			
		}

		private void pbExit_MouseHover(object sender, EventArgs e)
		{
			pbExit.BackColor = Color.Red;
			
		}

		private void pbExit_MouseLeave(object sender, EventArgs e)
		{
			pbExit.BackColor = Color.White;
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Normal)
			{
				WindowState = FormWindowState.Maximized;
			}
			else
			{

				WindowState = FormWindowState.Normal;
				this.Width= 1060;
				this.Height = 700;


			}
			
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			FrmEmpleado frmEmpleado = new FrmEmpleado();
			frmEmpleado.empleadoService = empleadoService;
			frmEmpleado.ShowDialog();
			guna2DataGridView1.Columns.Clear();
			guna2DataGridView1.DataSource = empleadoService.GetResumenEmpleados();
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			FrmEditarEmpleado frmEditar = new FrmEditarEmpleado();
			frmEditar.Show();
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{

		}
	}
}
