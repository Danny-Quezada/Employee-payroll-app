
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
				verificarDatos(txtNombre.Texts, txtSalario.Texts, txtCodigoInss.Texts, txtHorasTrabajadas.Texts);
				bool bandera = ValidacionINSS();
				if (bandera)
				{
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
					Empleado empleado = new Empleado(txtNombre.Texts, rem, txtCodigoInss.Texts, deducciones, aguinaldo, indemnizacion, prestamo, vacaciones)
					{
						Cargos = (Cargos)cmbCargos.SelectedIndex,
						Id = empleadoService.GetLastId() + 1,
						Imagen = ImagenAArray(PBImagen.Image)

					};
					empleadoService.Create(empleado);
					Dispose();
				}
				else
                {
					MessageBox.Show("Dos empleados no pueden tener el mismo código INSS", "Error en el código INSS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
		private void verificarDatos(string nombre, string salario, string noINSS, string hrs)
        {
			if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(noINSS) || string.IsNullOrEmpty(salario) ||  cmbCargos.SelectedIndex==-1)
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
			if(int.Parse(hrs)<0 || int.Parse(hrs) > 36)
            {
				throw new ArgumentException("Un trabajador no puede tener esas horas extra");
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
		private bool ValidacionINSS()
        {
			List<Empleado> empleados = (List<Empleado>)empleadoService.FindAll(1);
			empleados.AddRange(empleadoService.FindAll(2));
			foreach (Empleado a in empleados)
			{
				if (a.CodigoINSS == txtCodigoInss.Texts)
				{
					return false;
				}
			}
			return true;
		}

		private void btnRecontratar_Click(object sender, EventArgs e)
		{
			FrmRecontratar Recontratar = new FrmRecontratar();
			Recontratar.Despedidos = empleadoService;
			this.Hide();
			Recontratar.ShowDialog();
		
			
		}
	}

}
