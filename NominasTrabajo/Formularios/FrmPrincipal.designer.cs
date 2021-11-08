
namespace NominasTrabajo
{
	partial class FrmPrincipal
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblNomina = new System.Windows.Forms.Label();
            this.btnVerNominas = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnModificar = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnNext = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMINSS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasExtras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IngresoHorasExtras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSalario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INSSlaboral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDeducciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetoARecibir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INSSPatronal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aguinaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vacaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Indemnizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INATEC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 59;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.NUMINSS,
            this.Nombre,
            this.Cargo,
            this.Sueldo,
            this.HorasExtras,
            this.IngresoHorasExtras,
            this.TotalSalario,
            this.INSSlaboral,
            this.IR,
            this.TotalDeducciones,
            this.NetoARecibir,
            this.INSSPatronal,
            this.Prestamo,
            this.Aguinaldo,
            this.Vacaciones,
            this.Indemnizacion,
            this.INATEC});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.White;
            this.guna2DataGridView1.Location = new System.Drawing.Point(17, 70);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowTemplate.DividerHeight = 2;
            this.guna2DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(1107, 606);
            this.guna2DataGridView1.TabIndex = 0;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 59;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 21;
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 16;
            this.guna2Elipse1.TargetControl = this.guna2DataGridView1;
            // 
            // lblNomina
            // 
            this.lblNomina.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNomina.AutoSize = true;
            this.lblNomina.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomina.ForeColor = System.Drawing.Color.DarkGray;
            this.lblNomina.Location = new System.Drawing.Point(339, 9);
            this.lblNomina.Name = "lblNomina";
            this.lblNomina.Size = new System.Drawing.Size(133, 45);
            this.lblNomina.TabIndex = 2;
            this.lblNomina.Text = "Nómina";
            // 
            // btnVerNominas
            // 
            this.btnVerNominas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerNominas.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnVerNominas.CheckedState.Parent = this.btnVerNominas;
            this.btnVerNominas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerNominas.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnVerNominas.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnVerNominas.HoverState.Parent = this.btnVerNominas;
            this.btnVerNominas.Image = ((System.Drawing.Image)(resources.GetObject("btnVerNominas.Image")));
            this.btnVerNominas.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnVerNominas.ImageRotate = 0F;
            this.btnVerNominas.Location = new System.Drawing.Point(1101, 291);
            this.btnVerNominas.Name = "btnVerNominas";
            this.btnVerNominas.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnVerNominas.PressedState.Parent = this.btnVerNominas;
            this.btnVerNominas.ShadowDecoration.Parent = this.btnVerNominas;
            this.btnVerNominas.Size = new System.Drawing.Size(145, 126);
            this.btnVerNominas.TabIndex = 10;
            this.btnVerNominas.Visible = false;
            this.btnVerNominas.Click += new System.EventHandler(this.btnVerNominas_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnEliminar.CheckedState.Parent = this.btnEliminar;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnEliminar.HoverState.Parent = this.btnEliminar;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.btnEliminar.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnEliminar.ImageRotate = 0F;
            this.btnEliminar.ImageSize = new System.Drawing.Size(60, 60);
            this.btnEliminar.Location = new System.Drawing.Point(1125, 532);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnEliminar.PressedState.Parent = this.btnEliminar;
            this.btnEliminar.ShadowDecoration.Parent = this.btnEliminar;
            this.btnEliminar.Size = new System.Drawing.Size(84, 75);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnModificar.CheckedState.Parent = this.btnModificar;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnModificar.HoverState.ImageSize = new System.Drawing.Size(56, 56);
            this.btnModificar.HoverState.Parent = this.btnModificar;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnModificar.ImageRotate = 0F;
            this.btnModificar.ImageSize = new System.Drawing.Size(60, 60);
            this.btnModificar.Location = new System.Drawing.Point(1125, 423);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnModificar.PressedState.Parent = this.btnModificar;
            this.btnModificar.ShadowDecoration.Parent = this.btnModificar;
            this.btnModificar.Size = new System.Drawing.Size(84, 81);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Visible = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1111, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1149, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbExit
            // 
            this.pbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.Location = new System.Drawing.Point(1180, -1);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(44, 22);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExit.TabIndex = 5;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            this.pbExit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbExit_MouseDown);
            this.pbExit.MouseLeave += new System.EventHandler(this.pbExit_MouseLeave);
            this.pbExit.MouseHover += new System.EventHandler(this.pbExit_MouseHover);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAgregar.CheckedState.Parent = this.btnAgregar;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnAgregar.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAgregar.HoverState.Parent = this.btnAgregar;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAgregar.ImageRotate = 0F;
            this.btnAgregar.ImageSize = new System.Drawing.Size(70, 70);
            this.btnAgregar.Location = new System.Drawing.Point(1130, 209);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAgregar.PressedState.Parent = this.btnAgregar;
            this.btnAgregar.ShadowDecoration.Parent = this.btnAgregar;
            this.btnAgregar.Size = new System.Drawing.Size(79, 76);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnNext.CheckedState.Parent = this.btnNext;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnNext.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnNext.HoverState.Parent = this.btnNext;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnNext.ImageRotate = 0F;
            this.btnNext.Location = new System.Drawing.Point(1145, 116);
            this.btnNext.Name = "btnNext";
            this.btnNext.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnNext.PressedState.Parent = this.btnNext;
            this.btnNext.ShadowDecoration.Parent = this.btnNext;
            this.btnNext.Size = new System.Drawing.Size(64, 68);
            this.btnNext.TabIndex = 11;
            this.btnNext.Click += new System.EventHandler(this.btnSiguienteNomina_Click);
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Número";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // NUMINSS
            // 
            this.NUMINSS.HeaderText = "Número INSS";
            this.NUMINSS.Name = "NUMINSS";
            this.NUMINSS.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            // 
            // Sueldo
            // 
            this.Sueldo.HeaderText = "Sueldo";
            this.Sueldo.Name = "Sueldo";
            this.Sueldo.ReadOnly = true;
            // 
            // HorasExtras
            // 
            this.HorasExtras.HeaderText = "Horas extras";
            this.HorasExtras.Name = "HorasExtras";
            this.HorasExtras.ReadOnly = true;
            // 
            // IngresoHorasExtras
            // 
            this.IngresoHorasExtras.HeaderText = "Ingreso horas extras";
            this.IngresoHorasExtras.Name = "IngresoHorasExtras";
            this.IngresoHorasExtras.ReadOnly = true;
            // 
            // TotalSalario
            // 
            this.TotalSalario.HeaderText = "Total Salario";
            this.TotalSalario.Name = "TotalSalario";
            this.TotalSalario.ReadOnly = true;
            // 
            // INSSlaboral
            // 
            this.INSSlaboral.HeaderText = "INSS laboral";
            this.INSSlaboral.Name = "INSSlaboral";
            this.INSSlaboral.ReadOnly = true;
            // 
            // IR
            // 
            this.IR.HeaderText = "IR";
            this.IR.Name = "IR";
            this.IR.ReadOnly = true;
            // 
            // TotalDeducciones
            // 
            this.TotalDeducciones.HeaderText = "Deducciones";
            this.TotalDeducciones.Name = "TotalDeducciones";
            this.TotalDeducciones.ReadOnly = true;
            // 
            // NetoARecibir
            // 
            this.NetoARecibir.HeaderText = "Neto a recibir";
            this.NetoARecibir.Name = "NetoARecibir";
            this.NetoARecibir.ReadOnly = true;
            // 
            // INSSPatronal
            // 
            this.INSSPatronal.HeaderText = "INSS patronal";
            this.INSSPatronal.Name = "INSSPatronal";
            this.INSSPatronal.ReadOnly = true;
            // 
            // Prestamo
            // 
            this.Prestamo.HeaderText = "Prestamos";
            this.Prestamo.Name = "Prestamo";
            this.Prestamo.ReadOnly = true;
            // 
            // Aguinaldo
            // 
            this.Aguinaldo.HeaderText = "Aguinaldo";
            this.Aguinaldo.Name = "Aguinaldo";
            this.Aguinaldo.ReadOnly = true;
            // 
            // Vacaciones
            // 
            this.Vacaciones.HeaderText = "Vacaciones";
            this.Vacaciones.Name = "Vacaciones";
            this.Vacaciones.ReadOnly = true;
            // 
            // Indemnizacion
            // 
            this.Indemnizacion.HeaderText = "Indemnizacion";
            this.Indemnizacion.Name = "Indemnizacion";
            this.Indemnizacion.ReadOnly = true;
            // 
            // INATEC
            // 
            this.INATEC.HeaderText = "INATEC";
            this.INATEC.Name = "INATEC";
            this.INATEC.ReadOnly = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1221, 700);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnVerNominas);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblNomina);
            this.Controls.Add(this.guna2DataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1060, 700);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
		private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
		private Guna.UI2.WinForms.Guna2ImageButton btnAgregar;
		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
		private System.Windows.Forms.PictureBox pbExit;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private Guna.UI2.WinForms.Guna2ImageButton btnModificar;
		private Guna.UI2.WinForms.Guna2ImageButton btnEliminar;
		private System.Windows.Forms.Label lblNomina;
        private Guna.UI2.WinForms.Guna2ImageButton btnVerNominas;
        private Guna.UI2.WinForms.Guna2ImageButton btnNext;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMINSS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sueldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasExtras;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngresoHorasExtras;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSalario;
        private System.Windows.Forms.DataGridViewTextBoxColumn INSSlaboral;
        private System.Windows.Forms.DataGridViewTextBoxColumn IR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDeducciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetoARecibir;
        private System.Windows.Forms.DataGridViewTextBoxColumn INSSPatronal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aguinaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vacaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indemnizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn INATEC;
    }
}