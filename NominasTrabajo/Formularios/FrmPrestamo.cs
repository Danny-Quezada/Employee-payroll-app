using AppCore.Interfaces;
using Domain.Entities.Empleados;
using Domain.Enums;
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
    public partial class FrmPrestamo : Form
    {
        public IEmpleadoService empleadoService { get; set; }
        public Empleado emp { get; set; }
        public FrmPrestamo(IEmpleadoService empleadoService, Empleado empleado)
        {
            this.empleadoService = empleadoService;
            this.emp = empleado;
            InitializeComponent();
        }

        private void cmbTiempo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmPrestamo_Load(object sender, EventArgs e)
        {
            txtId.Focus();
            txtId.Text = emp.Id.ToString();
            cmbTiempo.Items.AddRange(Enum.GetValues(typeof(TiempoPrestamo)).Cast<object>().ToArray());
            txtNoINSS.Text = emp.CodigoINSS.ToString();
            txtNombre.Text = emp.NombreCompleto;
            txtSalario.Text = emp.Remuneraciones.SalarioBase.ToString();
        }

        public bool ValidacionPrestamo(decimal prestamo, decimal salario, int Cmb)
        {
            if (salario > (prestamo / ((Cmb + 1) * 12)))
            {
                return true;
            }
            return false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void ValidacionCamposVacios()
        {
            if (string.IsNullOrEmpty(txtPrestamo.Texts) || cmbTiempo.SelectedIndex == -1)
            {
                throw new ArgumentException("Usted no ha rellenado todos los campos para la solicitud de su prestamo");
                
            }
        }
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            try
            {
                ValidacionCamposVacios();
                if (decimal.Parse(txtPrestamo.Texts) <= 0)
                {
                    throw new ArgumentException("Monto del prestamo incorrecto, el monto debe de ser mayor a 0");
                }
                bool bandera = ValidacionPrestamo(decimal.Parse(txtPrestamo.Texts), emp.Remuneraciones.SalarioBase, cmbTiempo.SelectedIndex);
                if (bandera)
                {
                    emp.Prestamo.Cuota_Prestamo = decimal.Parse(txtPrestamo.Texts) / ((cmbTiempo.SelectedIndex + 1) * 12);
                    emp.Prestamo.MesesPrestamo = (cmbTiempo.SelectedIndex + 1) * 12;
                    MessageBox.Show($"El pago mensual que dara por el prestamo será de: {emp.Prestamo.Cuota_Prestamo}", "Aviso importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    empleadoService.Update(emp, 1);
                    this.Hide();
                }
                else
                {
                    throw new ArgumentException("La cuota que pagara mensualmente no puede ser mayor a su salario base");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtPrestamo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Solo se pueden colocar numeros enteros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
    }
}
