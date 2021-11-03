using AppCore.Interfaces;
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
    public partial class Despedir : Form
    {
        public IEmpleadoService empleadoService { get; set; }
        public Despedir()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            validar();
            int Id = int.Parse(txtid.Text);
            empleadoService.Despedir(Id);
            Dispose();
        }


        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Solo se pueden colocar numeros enteros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
        private void validar()
        {
            if (string.IsNullOrEmpty(txtid.Text))
            {
                throw new ArgumentException("Porfavor ingrese el id del despedido");
            }
            if (int.Parse(txtid.Text) < 0)
            {
                throw new ArgumentException("no exiate este trabajador");
            }
        }
    }
}
