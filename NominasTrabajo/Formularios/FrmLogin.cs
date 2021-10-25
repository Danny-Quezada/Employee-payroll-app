
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NominasTrabajo
{
	public partial class FrmLogin : Form
	{
		public FrmLogin()
		{
			InitializeComponent();
		}

	

		private void guna2GradientButton1_Click(object sender, EventArgs e)
		{
			var user = "admin";
			var contrasena = "LaDaRoKe";
			
			
			if(rjTextBox1.Texts.Equals(user) && rjTextBox2.Texts.Equals(contrasena))
            {
				this.Hide();
				FrmPrincipal frm = new FrmPrincipal();
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
			var contrasena = "LaDaRoKe";
			if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
				if (rjTextBox1.Texts.Equals(user) && rjTextBox2.Texts.Equals(contrasena))
				{
					this.Hide();
					FrmPrincipal frm = new FrmPrincipal();
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
