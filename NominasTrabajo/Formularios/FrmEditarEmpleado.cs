using AppCore.Interfaces;
using Domain.Entities.Empleados;
using Domain.Enums.CargosEmpleados;
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
	public partial class FrmEditarEmpleado : Form
	{
		public IEmpleadoService empleadoService { get; set; }
		public FrmEditarEmpleado()
		{
			InitializeComponent();
		}

		private void FrmEditarEmpleado_Load(object sender, EventArgs e)
		{
			cmbCargos.Items.AddRange(Enum.GetValues(typeof(Cargos)).Cast<object>().ToArray());
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void guna2GradientButton1_Click(object sender, EventArgs e)
		{
			validaciones(txtID.Texts, txtNombre.Texts, txtSalario.Texts, txtNoInss.Texts, txtHoras.Texts);
			Remuneraciones rem = new Remuneraciones()
			{
				SalarioBase = decimal.Parse(txtSalario.Texts)
			};
			Empleado empleado = new Empleado(txtNombre.Texts, rem, txtNoInss.Texts, int.Parse(txtHoras.Texts))
			{
				Cargos = (Cargos)cmbCargos.SelectedIndex,
				Id = int.Parse(txtID.Texts)
			};
			empleadoService.Update(empleado);
			
			Dispose();
		}
		
		
		
		public void validaciones(string  id, string nombre, string salario, string noINSS, string hrs) {
			if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(noINSS) || string.IsNullOrEmpty(salario) || string.IsNullOrEmpty(hrs) || cmbCargos.SelectedIndex == -1)
			{
				throw new ArgumentException("Hay campos vacios, rellenelos por favor");
			}
			if (noINSS.Length != 8)
			{
				throw new ArgumentException("El numero del INSS no puede tener menos o mas de 8 digitos");
			}
			if (int.Parse(hrs) < 240)
			{
				throw new ArgumentException("No se puede trabajar menos de 240 horas al mes");
			}
			if (decimal.Parse(salario) <= 0)
			{
				throw new ArgumentException("Un trabajador no puede ganar eso");
			}
			if (int.Parse(id) <= 0)
            {
				throw new ArgumentException("Este trabjador no existe");
			}
		}

        private void rjTextBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				MessageBox.Show("Solo se pueden colocar numeros enteros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				e.Handled = true;
			}
		}

        private void rjTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				MessageBox.Show("Solo se pueden colocar numeros enteros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				e.Handled = true;
			}
		}

        private void rjTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				MessageBox.Show("Solo se pueden colocar numeros enteros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				e.Handled = true;
			}
		}

        private void rjTextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				MessageBox.Show("Solo se pueden colocar numeros enteros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				e.Handled = true;
			}
		}
    }
}
