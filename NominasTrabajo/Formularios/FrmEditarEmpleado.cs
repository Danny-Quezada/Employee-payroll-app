using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using AppCore.Interfaces;
using Domain.Entities.Empleados;
using Domain.Enums.CargosEmpleados;

namespace NominasTrabajo
{
    public partial class FrmEditarEmpleado : Form
	{
		public IEmpleadoService empleadoService { get; set; }
		public Empleado emp { get; set; }
		public int a { get; set; }
		public FrmEditarEmpleado()
		{
			InitializeComponent();
		}

		private void FrmEditarEmpleado_Load(object sender, EventArgs e)
		{
			txtId.Focus();
			txtId.Text = emp.Id.ToString();
			cmbCargos.Items.AddRange(Enum.GetValues(typeof(Cargos)).Cast<object>().ToArray());
			txtHrsExtras.Text = emp.Remuneraciones.HorasExtras.ToString();
			txtNoINSS.Text = emp.CodigoINSS.ToString();
			txtNombre.Text = emp.NombreCompleto;
			txtSalario.Text = emp.Remuneraciones.SalarioBase.ToString();
			rjCircularPictureBox1.Image = byteArrayToImage(emp.Imagen);
			rjCircularPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			cmbCargos.SelectedIndex = (int)emp.Cargos;
		}
		public Image byteArrayToImage(byte[] byteArrayIn)
		{
			MemoryStream ms = new MemoryStream(byteArrayIn);
			Image returnImage = Image.FromStream(ms);
			return returnImage;
		}
		public byte[] ImagenAArray(Image img)
		{
			MemoryStream ms = new MemoryStream();
			img.Save(ms, img.RawFormat);
			return ms.ToArray();
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
            try
            {
				validaciones(txtId.Text, txtNombre.Text, txtSalario.Text, txtNoINSS.Text, txtHrsExtras.Text);
				Remuneraciones rem = new Remuneraciones()
				{
					SalarioBase = decimal.Parse(txtSalario.Text),
					HorasExtras = int.Parse(txtHrsExtras.Text),

				};
				Deducciones deducciones = new Deducciones();
				Aguinaldo aguinaldo = new Aguinaldo()
				{
					MesesTrabajadosAguinaldo = emp.Aguinaldo.MesesTrabajadosAguinaldo
				};
				Prestamo prestamo = new Prestamo()
				{
					MesesPrestamo = emp.Prestamo.MesesPrestamo,
					Cuota_Prestamo = emp.Prestamo.Cuota_Prestamo
				};
				Indemnizacion indemnizacion = new Indemnizacion()
				{
					MesesTrabajadosIndemnizacion = emp.Indemnizacion.MesesTrabajadosIndemnizacion,
					AñosTrabajadosIndemnizacion = emp.Indemnizacion.AñosTrabajadosIndemnizacion
				};
				Vacaciones vacaciones = new Vacaciones()
				{
					MesesTrabajadosVacaciones = emp.Vacaciones.MesesTrabajadosVacaciones
				};
				Empleado empleado = new Empleado(txtNombre.Text, rem, txtNoINSS.Text, deducciones, aguinaldo, indemnizacion, prestamo, vacaciones)
				{
					Cargos = (Cargos)cmbCargos.SelectedIndex,
					Id = int.Parse(txtId.Text),
					Imagen = ImagenAArray(rjCircularPictureBox1.Image)
				};
				empleado.PagoPendiente = emp.PagoPendiente;
				empleadoService.Update(empleado, a);

				Dispose();
			}
            catch (Exception ex)
            {
				MessageBox.Show(ex.Message, "ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
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
			if (int.Parse(hrs) < 0 || int.Parse(hrs) > 36)
			{
				throw new ArgumentException("El numero que ha ingresado en las horas extras debe ser mayor a 0 y menor a 36");
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

        private void rjTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				MessageBox.Show("Solo se pueden colocar numeros enteros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				e.Handled = true;
			}
		}
		//TODO: validarDecimales
        private void rjTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				MessageBox.Show("Solo se pueden colocar numeros enteros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				e.Handled = true;
			}
		}

		private void rjCircularPictureBox1_Click(object sender, EventArgs e)
		{
			OpenFileDialog result = new OpenFileDialog();
			result.Title = "Open Image";
			result.Filter = "Archivo JPG (*.jpg)|*.jpg| Archivo PNG (*.png)|*.png| Archivo BMP (*.bmp)|*bmp";
			if (result.ShowDialog() == DialogResult.OK)
			{
				rjCircularPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
				rjCircularPictureBox1.Image = Image.FromFile(result.FileName);
			}
	
			result.Dispose();
		}
	}
}
