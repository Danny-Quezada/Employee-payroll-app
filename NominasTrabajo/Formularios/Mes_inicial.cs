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
        private IEmpleadoService despedidos;
        private IProcesses processes;
        private IEmpresaService empresaService;

        public Mes_inicial(IEmpleadoService empleado, IEmpleadoService despedidos, IProcesses processes, IEmpresaService empresaService)
        {
            this.despedidos = despedidos;
            this.empleadoService = empleado;
            this.processes = processes;
            this.empresaService = empresaService;
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
                FrmPrincipal frm = new FrmPrincipal(processes, empresaService,  cmbMeses.SelectedIndex);
                frm.empleadoService = empleadoService;
				frm.despedidos = despedidos;
                frm.ShowDialog();
                this.Close();
            }
        }
    }
}
