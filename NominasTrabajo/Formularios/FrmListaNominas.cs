using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCore.Interfaces;
using Domain.Entities.Nominas;
using Domain.Enums;

namespace NominasTrabajo.Formularios
{
    public partial class FrmListaNominas : Form
    {
        private INominaService nominaService;
        public IEmpresaService empresaService { get; set; }
        public FrmListaNominas(INominaService nominaService)
        {
            this.nominaService = nominaService;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FrmListaNominas_Load(object sender, EventArgs e)
        {
			if (nominaService.FindAll().Count > 1)
			{
                btnEstadisticas.Visible = true;
			}
            llenarListView(nominaService.FindAll());
            cmbBusqueda.Items.AddRange(Enum.GetValues(typeof(FiltrosNomina)).Cast<object>().ToArray());
            cmbMeses.Items.AddRange(Enum.GetValues(typeof(Meses)).Cast<object>().ToArray());
        }
        private void llenarListView(ICollection<Nomina> nominas)
        {
            if (nominas != null)
            {
                listView1.Items.Clear();
                foreach(Nomina n in nominas)
                {
                    ListViewItem item = new ListViewItem();
                    item = listView1.Items.Add(n.Id.ToString());
                    item.SubItems.Add(n.Mes.ToString());
                    item.SubItems.Add(n.Año.ToString());
                    item.SubItems.Add(n.TotalEmpleados.ToString());
                    item.SubItems.Add(n.TotalNomina.ToString());
                }
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cmbBusqueda.SelectedIndex)
                {
                    case -1:
                        throw new ArgumentException("Tiene que seleccionar un criterior de busqueda");
                    case 0:
                        if (cmbMeses.SelectedIndex == -1)
                        {
                            throw new ArgumentException("No seleccione ningun mes");
                        }
                        llenarListView(nominaService.FindAll(n => n.Mes == (Meses)cmbMeses.SelectedIndex));
                        break;
                    case 1:
                        int año = int.Parse(txtFinder.Text);
                        //lo pongo asi porque es el año minimo que puede tener una nomina que generamos
                        if (año < 2021)
                        {
                            throw new ArgumentException("No hay nominas que se hayan generado antes del 2021");
                        }
                        llenarListView(nominaService.FindAll(n => n.Año == año));
                        break;
                    case 2:
                        llenarListView(nominaService.FindAll());
                        break;
                }
                cmbMeses.SelectedIndex = -1;
                txtFinder.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void cmbBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbBusqueda.SelectedIndex)
            {
                case 0:
                    cmbMeses.Visible = true;
                    txtFinder.Visible = false;
                    break;
                case 1:
                    cmbMeses.Visible = false;
                    txtFinder.Visible = true;
                    break;
                case 2:
                    cmbMeses.Visible = false;
                    txtFinder.Visible = false;
                    break;
            }
        }

        private void txtFinder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Solo se pueden colocar numeros enteros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            int index=int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            Nomina n=nominaService.FindAny(x=>x.Id==index);
            if (n == null)
            {
                MessageBox.Show("No selecciono ninguna nomina","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            this.Hide();
            FrmPrincipal frmPrincipal = new FrmPrincipal(n,empresaService);
            frmPrincipal.ShowDialog();
            this.Close();
        }

		private void txtFinder_TextChanged(object sender, EventArgs e)
		{

		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnEstadisticas_Click(object sender, EventArgs e)
		{
            FrmEstadisticas Estadisticas = new FrmEstadisticas(nominaService);
            Estadisticas.ShowDialog();
		}
	}
}
