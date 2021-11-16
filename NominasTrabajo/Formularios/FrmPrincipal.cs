using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCore.Interfaces;
using Domain.Entities.Empleados;
using Domain.Entities.Nominas;
using Domain.Enums;
using Domain.Interfaces;
using Infraestructure.EmpleadosRepos;
using iTextSharp.text;
using iTextSharp.text.pdf;
using NominasTrabajo.Formularios;


namespace NominasTrabajo

{

    public partial class FrmPrincipal : Form
    {
        private int Mes;
        private int year = 2021;
        private int n = 0;
        private Nomina nomina;
        public IEmpleadoService empleadoService { get; set; }
        //TODO: nunca se ocupa processes
        private IProcesses processes;
        private IEmpresaService empresaService;
        private INominaService nominaService;
        public FrmPrincipal(IProcesses processes, IEmpresaService empresaService, int Mes, INominaService nominaService)
        {
            this.processes = processes;
            this.empresaService = empresaService;
            this.Mes = Mes;
            this.nominaService = nominaService;
            //EmpleadoListRepository empleadoListRepository = new EmpleadoListRepository(processes, empresaService);
            InitializeComponent();

        }
        public FrmPrincipal(Nomina nomina, IEmpresaService empresaService)
        {

            InitializeComponent();
            this.nomina = nomina;
            this.empresaService = empresaService;
            CargarNominaVieja(this.nomina);
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
		{
			
			if (nomina == null)
            {
                Meses mes = (Meses)Mes;
                lblNomina.Text = $"Nómina del mes de {mes} del año {year}";
            }
        }



        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if ((e.RowIndex >= 0 && e.RowIndex<guna2DataGridView1.Rows.Count-1) && nomina == null)
                {
                    n = e.RowIndex;
                    //if (guna2DataGridView1.Rows[n].Cells[0].Value.ToString() == "")
                    //{
                    //    throw new ArgumentException();
                    //}
                    int id = Convert.ToInt32(guna2DataGridView1.Rows[n].Cells[0].Value);
                    Empleado empleado = empleadoService.GetEmpleadoById(id);
                    if (empleado == null)
                    {
                        throw new Exception();
                    }
                    if (empleado.Estado == EstadoTrabajador.Inactivo)
                    {
                        throw new Exception();
                    }
                    //aqui modifique
                    if (empleado.MesesTrabajados > 6)
                    {
                        btnPrestamo.Visible = true;
                    }
                    else
                    {
                        btnPrestamo.Visible = false;
                    }
                    btnModificar.Visible = true;
                    btnEliminar.Visible = true;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                btnModificar.Visible = false;
                btnEliminar.Visible = false;
                btnPrestamo.Visible = false;
                return;
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbExit_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pbExit_MouseHover(object sender, EventArgs e)
        {
            pbExit.BackColor = Color.Red;

        }

        private void pbExit_MouseLeave(object sender, EventArgs e)
        {
            pbExit.BackColor = Color.White;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {

                WindowState = FormWindowState.Normal;
                this.Width = 1060;
                this.Height = 700;


            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmEmpleado frmEmpleado = new FrmEmpleado();
            frmEmpleado.empleadoService = empleadoService;

            frmEmpleado.ShowDialog();
            
                guna2DataGridView1.Rows.Clear();
                //guna2DataGridView1.DataSource = empleadoService.GetResumenEmpleados();
                llenarDgv(empleadoService.GetResumenEmpleados(Mes));
            
          
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int idElegido = Convert.ToInt32(guna2DataGridView1.Rows[n].Cells[0].Value);
                Empleado empleado = empleadoService.GetEmpleadoById(idElegido);
                if (empleado == null)
                {
                    throw new ArgumentException("El empleado no se encuentra en la lista de empleados activos");
                }
                FrmEditarEmpleado frmEditar = new FrmEditarEmpleado();
                frmEditar.emp = empleado;
                frmEditar.a = 1;
                frmEditar.empleadoService = empleadoService;
                frmEditar.ShowDialog();
                guna2DataGridView1.Rows.Clear();
                llenarDgv(empleadoService.GetResumenEmpleados(Mes));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var a = (guna2DataGridView1.Rows[n].Cells[0].Value);
                Empleado empleado = empleadoService.GetEmpleadoById((int)a);
                EmpleadoDgv empleadoDgv = empleadoService.GetResumenEmpleado((int)a, Mes);
                if (empleadoService.Despedir((int)a))
                {
                    MessageBox.Show("El empleado ha sido despedido correctamente", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                guna2DataGridView1.Rows[n].DefaultCellStyle.ForeColor = Color.Red;
                guna2DataGridView1.Rows.Clear();
                llenarDgv(empleadoService.GetResumenEmpleados(Mes));
                MensajeDeDeuda(empleado);
            }    
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void llenarDgv(EmpleadoDgv[] empleadosResumen)
        {
            int i = 0;
            if (empleadosResumen != null)
            {
                decimal sumaSalario = 0, sumaIngresHrs = 0, sumaIngresos = 0, sumaINSSLab = 0, sumaIR = 0, sumaDeducc = 0, sumaNeta = 0, sumaINSSPatronal = 0, sumaAguinaldo = 0;
                decimal sumaPrestamo = 0, sumaVacacion = 0, sumaIndem = 0;
                foreach (EmpleadoDgv emp in empleadosResumen)
                {
                    if ((Meses) Mes != Meses.Diciembre)
                    {
                        emp.Aguinaldo = 0;
                        guna2DataGridView1.Rows.Add(emp.Id, emp.CodigoINSS, emp.Nombre_Completo, emp.Cargo, emp.Salario_Mensual, emp.Horas_Extras,
                        emp.Ingreso_Horas_Extras, emp.Total_Ingresos, emp.INSS_Laboral, emp.IR, emp.Total_Deducciones, emp.Neto_A_Recibir, emp.INSS_Patronal,
                        emp.Cuota_Prestamo, emp.Aguinaldo, emp.Vacaciones, emp.Indemnizacion,"");
                    }
                    else
                    {
                        guna2DataGridView1.Rows.Add(emp.Id, emp.CodigoINSS, emp.Nombre_Completo, emp.Cargo, emp.Salario_Mensual, emp.Horas_Extras,
                       emp.Ingreso_Horas_Extras, emp.Total_Ingresos, emp.INSS_Laboral, emp.IR, emp.Total_Deducciones, emp.Neto_A_Recibir, emp.INSS_Patronal,
                       emp.Cuota_Prestamo, emp.Aguinaldo, emp.Vacaciones, emp.Indemnizacion);
                    }

                    sumaSalario += emp.Salario_Mensual;
                    sumaIngresHrs += emp.Ingreso_Horas_Extras;
                    sumaIngresos += emp.Total_Ingresos;
                    sumaINSSLab += emp.INSS_Laboral;
                    sumaINSSPatronal += emp.INSS_Patronal;
                    sumaIndem += emp.Indemnizacion;
                    sumaIR += emp.IR;
                    sumaVacacion += emp.Vacaciones;
                    sumaNeta += emp.Neto_A_Recibir;
                    sumaAguinaldo += emp.Aguinaldo;
                    sumaDeducc += emp.Total_Deducciones;
                    sumaPrestamo += emp.Cuota_Prestamo;
                    if (emp.Estado == EstadoTrabajador.Inactivo)
                    {
                        guna2DataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                    }
                    i++;
                }

                guna2DataGridView1.Rows.Add("", "", "", "Total:", sumaSalario, "", sumaIngresHrs,
                    sumaIngresos, sumaINSSLab, sumaIR, sumaDeducc, sumaNeta, sumaINSSPatronal, sumaPrestamo, sumaAguinaldo, sumaVacacion, sumaIndem, empresaService.CalculateInatec(sumaIngresos));
            }
        }

        private void btnSiguienteNomina_Click(object sender, EventArgs e)
        {
            //Esto es para evitar que avance a la siguiente nomina sin haber agregado aunque sea un empleado
            if (empleadoService.GetResumenEmpleados(Mes) != null)
            {
                btnVerNominas.Visible = true;

                btnEliminar.Visible = false;
                btnModificar.Visible = false;
                btnPrestamo.Visible = false;

                Nomina nomina = new Nomina()
                {
                    Id = nominaService.GetLastId() + 1,
                    Empleados = empleadoService.GetResumenEmpleados(Mes),
                    Mes = (Meses)Mes,
                    Año = year
                };
                Mes++;
                nominaService.Create(nomina);
                empleadoService.QuitarDespedidosDelMes();
                empleadoService.AumentarAntiguedad((Meses)Mes);
                if (Mes > 11)
                {
                    Mes = 0;
                    year++;
                }
                ColocarMesAño(Mes, year);
                guna2DataGridView1.Rows.Clear();
                llenarDgv(empleadoService.GetResumenEmpleados(Mes));
            }
            else
            {
                MessageBox.Show("Debe de agregar aunque sea un empleado para pasar a la siguiente nomina", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ColocarMesAño(int mes, int año)
        {
            Meses month = (Meses)mes;
            lblNomina.Text = $"Nómina del mes de {month} del año {año}";
        }
        private void btnVerNominas_Click(object sender, EventArgs e)
        {
            FrmListaNominas frmListaNominas = new FrmListaNominas(nominaService);
            frmListaNominas.empresaService = empresaService;
            frmListaNominas.ShowDialog();
        }
        private void CargarNominaVieja(Nomina nomina)
        {
            ColocarMesAño((int)nomina.Mes, nomina.Año);
            llenarDgv(nomina.Empleados);
            btnAgregar.Visible = false;
            btnNext.Visible = false;
            btnEstadisticas.Visible = true;
            //TODO: aqui se habilitarian los botones de imprimir y excel
        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(guna2DataGridView1.Rows[n].Cells[0].Value);
                Empleado empleado = empleadoService.GetEmpleadoById(id);
                if (empleado == null)
                {
                    throw new ArgumentException("El empleado no se encuentra en la lista de empleados activos");
                }
                if (empleado.Prestamo.Cuota_Prestamo == 0)
                {
                    FrmPrestamo frmPrestamo = new FrmPrestamo(empleadoService, empleado);
                    frmPrestamo.ShowDialog();
                    guna2DataGridView1.Rows.Clear();
                    llenarDgv(empleadoService.GetResumenEmpleados(Mes));
                }
                else
                {
                    MessageBox.Show("No se puede pedir un prestamo debido a que ya tiene un prestamo vigente", "Error en pedir un prestamo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void guna2ImageButton1_Click(object sender, EventArgs e)
		{
            Excel(guna2DataGridView1);
		}
		private void Excel(DataGridView Lista)
		{
			if (guna2DataGridView1.Rows.Count > 0)
			{
                Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application(); // Creo el objeto Excel 
                Excel.Application.Workbooks.Add(true);  // Creo la hoja de excel
                int indiceColumna = 0;

                foreach(DataGridViewColumn col in Lista.Columns)
				{
                    indiceColumna++;
                    Excel.Cells[1, indiceColumna] = col.HeaderText;
				}
                int indiceFila = 0;
                foreach(DataGridViewRow fila in Lista.Rows)
				{
                    indiceFila++;
                    indiceColumna = 0;
                    foreach(DataGridViewColumn col in Lista.Columns)
					{
                        indiceColumna++;
						Excel.Cells[indiceFila + 1, indiceColumna] = fila.Cells[col.Name].Value;
                        
					}
				}

                Excel.Columns.AutoFit();
                SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.Filter = "Archivo excel (*xlsx)|*.xlsx";
                saveFileDialog.FileName = $"{lblNomina.Text}";
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
                    Console.WriteLine(saveFileDialog.FileName);
                    Excel.ActiveWorkbook.SaveCopyAs(saveFileDialog.FileName);
                    Excel.ActiveWorkbook.Saved = true;
                    Excel.Quit();
				}

			
            }
		}
        private void MensajeDeDeuda(Empleado e)
        {
            if (e.PagoPendiente > 0)
            {
                MessageBox.Show($"El empleado {e.NombreCompleto} le quedo debiendo a la empresa: {e.PagoPendiente}", "Pago pendiente del empleado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            exportar(guna2DataGridView1, $"{lblNomina.Text}");
        }
        private void exportar(DataGridView dgw,string FileName)
		{
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(dgw.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;
            iTextSharp.text.Font text= new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            foreach(DataGridViewColumn col in dgw.Columns)
			{
                PdfPCell cel = new PdfPCell(new Phrase(col.HeaderText, text));
                cel.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cel);
			}
            foreach(DataGridViewRow row in dgw.Rows)
			{
                foreach(DataGridViewCell cell in row.Cells)
				{
					
                    pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                    
				}
			}
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = FileName;
            save.DefaultExt = ".pdf";
			if (save.ShowDialog() == DialogResult.OK)
			{
                FileStream stream = new FileStream(save.FileName,FileMode.Create);
                Document doc = new Document(PageSize.A3,10f,10f,10f,0);
                PdfWriter.GetInstance(doc, stream);
                doc.Open();
                doc.Add(pdftable);
                doc.Close();
                stream.Close();
			}
		}

		private void btnEstadisticas_Click(object sender, EventArgs e)
		{
            FrmEstadisticas Estadisticas = new FrmEstadisticas();
            Estadisticas.Nomina = nomina;
            Estadisticas.ShowDialog();
		}

		private void lblNomina_Click(object sender, EventArgs e)
		{

		}
	}
}
