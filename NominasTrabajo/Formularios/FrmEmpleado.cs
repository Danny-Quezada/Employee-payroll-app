


using Domain.Empleado.CargosEmpleados;
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
			cmbCargos.Items.AddRange(Enum.GetValues(typeof(Cargos)).Cast<object>().ToArray());
			
		}
		public Image byteArrayToImage(byte[] byteArrayIn)
		{
			MemoryStream ms = new MemoryStream(byteArrayIn);
			Image returnImage = Image.FromStream(ms);
			return returnImage;
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

		}
	}

}
