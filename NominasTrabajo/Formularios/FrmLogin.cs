
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
using NominasTrabajo.Formularios;

namespace NominasTrabajo
{
	public partial class FrmLogin : Form
	{
		private IEmpleadoService empleadoService;
		private IEmpleadoService despedidos;
		private IProcesses processes;
		private IEmpresaService empresaService;
		public FrmLogin(IEmpleadoService empleado, IEmpleadoService despedidos, IProcesses processes, IEmpresaService empresaService)
		{
			this.despedidos = despedidos;
			this.empleadoService = empleado;
			this.processes = processes;
			this.empresaService = empresaService;
			InitializeComponent();
		}

	

		private void guna2GradientButton1_Click(object sender, EventArgs e)
		{
			var user = "admin";
			var contrasena = "ladaroke";
			
			
			if(rjTextBox1.Texts.Equals(user) && rjTextBox2.Texts.Equals(contrasena))
            {
				this.Hide();
				Mes_inicial frm = new Mes_inicial(empleadoService,despedidos,processes,empresaService);
				frm.ShowDialog();
				this.Close();
			}
            else
            {
				MessageBox.Show("Credenciales erroneas", "El Usuario o la contaseña no coinciden", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
			
			

		}

		private void FrmLogin_Load(object sender, EventArgs e)
		{
			guna2Transition1.ShowSync(this);
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void rjTextBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			var user = "admin";
			var contrasena = "ladaroke";
			if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
				if (rjTextBox1.Texts.Equals(user) && rjTextBox2.Texts.Equals(contrasena))
				{
					this.Hide();
					Mes_inicial frm = new Mes_inicial(empleadoService, despedidos, processes, empresaService);
					frm.ShowDialog();
					this.Close();
				}
				else
				{
					MessageBox.Show("Credenciales erroneas", "El Usuario o la contaseña no coinciden", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
        }
    }
}
