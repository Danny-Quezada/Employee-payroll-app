using AppCore.Interfaces;
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
    public partial class Mes_inicial : Form
    {
        private IEmpleadoService empleadoService;
        //TODO: nunca se ocupa processes
        private IProcesses processes;
        private IEmpresaService empresaService;
        private INominaService nominaService;
        public Mes_inicial(IEmpleadoService empleado, IProcesses processes, IEmpresaService empresaService, INominaService nominaService)
        {
            this.empleadoService = empleado;
            this.processes = processes;
            this.empresaService = empresaService;
            this.nominaService = nominaService;
            InitializeComponent();
        }

        private void Mes_inicial_Load(object sender, EventArgs e)
        {
            cmbMeses.Items.AddRange(Enum.GetValues(typeof(Meses)).Cast<object>().ToArray());
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbMeses.SelectedIndex == -1) {
                MessageBox.Show("debe elegir un mes del año");
            
            }
            else
            {
                this.Hide();
                FrmPrincipal frm = new FrmPrincipal(processes, empresaService,  cmbMeses.SelectedIndex, nominaService);
                frm.empleadoService = empleadoService;
                frm.ShowDialog();
                this.Close();
            }
        }
        //TODO: Todavia no se activa todavia el evento
        private void btnAgregar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnAgregar_Click(sender,e);
            }
        }

		private void pictureBox1_Click(object sender, EventArgs e)
		{
            this.WindowState = FormWindowState.Minimized;
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
            this.Close();
		}
	}
}
