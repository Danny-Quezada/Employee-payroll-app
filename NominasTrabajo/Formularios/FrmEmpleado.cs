
using AppCore.Interfaces;
using Domain.Entities.Empleados;
using Domain.Enums.CargosEmpleados;
using NominasTrabajo.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NominasTrabajo
{
	
	public partial class FrmEmpleado : Form
	{
		public IEmpleadoService empleadoService { get; set; }
		public FrmEmpleado()
		{
			InitializeComponent();
		}		
		private void pictureBox1_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void FrmEmpleado_Load(object sender, EventArgs e)
		{
		
			var despedidos = empleadoService.FindAll(2);
			if (despedidos.Count > 0)
			{
				btnRecontratar.Visible = true;
			}
			else
			{
				btnRecontratar.Visible = false;
			}
			cmbCargos.Items.AddRange(Enum.GetValues(typeof(Cargos)).Cast<object>().ToArray());
			
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


		private void PBImagen_Click(object sender, EventArgs e)
		{
			OpenFileDialog result = new OpenFileDialog();
			result.Title = "Open Image";
			result.Filter = "Archivo JPG (*.jpg)|*.jpg| Archivo PNG (*.png)|*.png| Archivo BMP (*.bmp)|*bmp";
			if (result.ShowDialog() == DialogResult.OK)
			{
				PBImagen.SizeMode = PictureBoxSizeMode.Zoom;
				PBImagen.Image = Image.FromFile(result.FileName);
			}
			result.Dispose();
		}

		private void pbWaves_Click(object sender, EventArgs e)
		{
			
		}

		private void txtNombre__TextChanged(object sender, EventArgs e)
		{

		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			try
			{
				verificarDatos(txtNombre.Texts, txtSalario.Texts, txtCodigoInss.Texts, txtHorasTrabajadas.Texts, txtCorreo.Texts, txtNumero.Texts, txtcedula.Texts);
				ValidacionesDeRepetidos();


				Remuneraciones rem = new Remuneraciones()
				{
					SalarioBase = decimal.Parse(txtSalario.Texts),
					HorasExtras = int.Parse(txtHorasTrabajadas.Texts)
				};
				Deducciones deducciones = new Deducciones();
				Prestamo prestamo = new Prestamo();
				Aguinaldo aguinaldo = new Aguinaldo()
				{
					MesesTrabajadosAguinaldo = 1
				};
				Indemnizacion indemnizacion = new Indemnizacion()
				{
					MesesTrabajadosIndemnizacion = 1
				};
				Vacaciones vacaciones = new Vacaciones()
				{
					MesesTrabajadosVacaciones = 1
				};
				Empleado empleado = new Empleado(txtNombre.Texts, rem, txtCodigoInss.Texts, deducciones, aguinaldo, indemnizacion, prestamo, vacaciones, txtNumero.Texts, txtCorreo.Texts, txtcedula.Texts)
				{
					Cargos = (Cargos)cmbCargos.SelectedIndex,
					Id = empleadoService.GetLastId() + 1,
					Imagen = ImagenAArray(PBImagen.Image)

				};
				empleadoService.Create(empleado);
				Dispose();


			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void verificarDatos(string nombre, string salario, string noINSS, string hrs, string correo, string numero, string cedula)
		{
			if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(noINSS) || string.IsNullOrEmpty(salario) || cmbCargos.SelectedIndex == -1 || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(numero) || string.IsNullOrEmpty(cedula))
			{
				throw new ArgumentException("Hay campos vacios, rellenelos por favor");
			}
			if (noINSS.Length != 8)
			{
				throw new ArgumentException("El numero del INSS no puede tener menos o mas de 8 digitos");
			}

			if (decimal.Parse(salario) <= 0)
			{
				throw new ArgumentException("Un trabajador no puede ganar eso");
			}
			if (int.Parse(hrs) < 0 || int.Parse(hrs) > 36)
			{
				throw new ArgumentException("Un trabajador no puede tener esas horas extra");
			}
			if (!Regex.IsMatch(correo, @"\A(\w+\.?\w*\@\w+\.)(com)\Z"))
			{
				throw new ArgumentException("Correo electronico invalido");
				//Más instrucciones...
			}
			if (!Regex.IsMatch(numero, @"\A[0-9]{4}(\-)[0-9]{4}\Z"))
			{
				throw new ArgumentException("numero de telefono invalido");
				//Más instrucciones...
			}
			if (!Regex.IsMatch(cedula, @"\A[0-9]{3}(\-)[0-9]{6}(\-)[0-9]{4}[A-Z]\Z"))
			{
				throw new ArgumentException("cedula ivalida");
				//Más instrucciones...
			}

		}

		private void txtHorasTrabajadas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Solo se pueden colocar numeros enteros","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
				e.Handled = true;
			}
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
			//poner validacion de decimales
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				MessageBox.Show("Solo se pueden colocar numeros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				e.Handled = true;
			}
		}

        private void txtCodigoInss_KeyPress(object sender, KeyPressEventArgs e)
        {
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				MessageBox.Show("Solo se pueden colocar numeros enteros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				e.Handled = true;
			}
		}

        private void txtHorasTrabajadas__TextChanged(object sender, EventArgs e)
        {

        }
		private void ValidacionesDeRepetidos()
		{
			//List<Empleado> empleados = (List<Empleado>)empleadoService.FindAll(1);
			//empleados.AddRange(empleadoService.FindAll(2));
			//foreach (Empleado a in empleados)
			//{
			//	if (a.CodigoINSS == txtCodigoInss.Texts)
			//	{
			//		return false;
			//	}
			//}
			//return true;
			List<Empleado> empleados1 = empleadoService.FindAll(1).ToList();
			List<Empleado> empleados2 = empleadoService.FindAll(2).ToList();

			foreach (Empleado e in empleados1)
			{
				if (e.CodigoINSS == txtCodigoInss.Texts)
				{
					throw new ArgumentException("no se puede repetir el codigo inss");
				}
			}
			foreach (Empleado e in empleados2)
			{
				if (e.CodigoINSS == txtCodigoInss.Texts)
				{
					throw new ArgumentException("no se puede repetir el codigo inss");
				}
			}
			//validar cedula
			foreach (Empleado e in empleados1)
			{
				if (e.Cedula == txtcedula.Texts)
				{
					throw new ArgumentException("no se puede repetir la cedula");
				}
			}
			foreach (Empleado e in empleados2)
			{
				if (e.Cedula == txtcedula.Texts)
				{
					throw new ArgumentException("no se puede repetir la cedula");
				}
			}
			//validar numero de telefono
			foreach (Empleado e in empleados1)
			{
				if (e.Numero == txtNumero.Texts)
				{
					throw new ArgumentException("no se puede repetir el numero de telefono");
				}
			}
			foreach (Empleado e in empleados2)
			{
				if (e.Numero == txtNumero.Texts)
				{
					throw new ArgumentException("no se puede repetir el numero de telefono");
				}
			}
			//validar correo electronico
			foreach (Empleado e in empleados1)
			{
				if (e.CorreoELectronico == txtCorreo.Texts)
				{
					throw new ArgumentException("no se puede repetir el correo electronico");
				}
			}
			foreach (Empleado e in empleados2)
			{
				if (e.Numero == txtCorreo.Texts)
				{
					throw new ArgumentException("no se puede repetir el correo electronico");
				}
			}

		}

		private void btnRecontratar_Click(object sender, EventArgs e)
		{
			FrmRecontratar Recontratar = new FrmRecontratar();
			Recontratar.Despedidos = empleadoService;
			this.Hide();
			Recontratar.ShowDialog();
		
			
		}

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txtNumero__TextChanged(object sender, EventArgs e)
		{

		}
	}

}
