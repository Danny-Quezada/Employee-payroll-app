
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
		private string user = "admin";
		private string contrasena = "ladaroke";
		private IEmpleadoService empleadoService;
		//TODO: nunca se ocupa processes
		private IProcesses processes;
		private IEmpresaService empresaService;
		private INominaService nominaService;
		public FrmLogin(IEmpleadoService empleado, IProcesses processes, IEmpresaService empresaService, INominaService nominaService)
		{
			this.empleadoService = empleado;
			this.processes = processes;
			this.empresaService = empresaService;
			this.nominaService = nominaService;
			InitializeComponent();
		}

		private void guna2GradientButton1_Click(object sender, EventArgs e)
		{
			if(rjTextBox1.Texts.Equals(user) && rjTextBox2.Texts.Equals(contrasena))
            {
				this.Hide();
				Mes_inicial frm = new Mes_inicial(empleadoService,processes,empresaService,nominaService);
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
			if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
				guna2GradientButton1_Click(sender, e);
			}
        }
    }
}
