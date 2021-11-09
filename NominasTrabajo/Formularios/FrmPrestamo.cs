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
        private int ValidacionCamposVacios()
        {
            if(txtPrestamo.Texts == "" || cmbTiempo.Text == null)
            {
                MessageBox.Show("Usted no ha rellenado todos los campos para la solicitud de su prestamo", "Error con los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }
            else
            {
                return 0;
            }
        }
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if(decimal.Parse(txtPrestamo.Texts) < 0)
            {
                MessageBox.Show("Monto del prestamo incorrecto, el monto debe de ser mayor a 0", "Error en el monto del prestamo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int validacion = ValidacionCamposVacios();
                if (validacion == 0)
                {
                    bool bandera = ValidacionPrestamo(decimal.Parse(txtPrestamo.Texts), emp.Remuneraciones.SalarioBase, cmbTiempo.SelectedIndex);
                    if (bandera)
                    {
                        emp.Prestamo = decimal.Parse(txtPrestamo.Texts) / ((cmbTiempo.SelectedIndex + 1) * 12);
                        emp.MesesPrestamo = (cmbTiempo.SelectedIndex + 1) * 12;
                        empleadoService.Update(emp);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("La cuota que pagara mensualmente no puede ser mayor a su salario base", "Error en el monto del prestamo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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
