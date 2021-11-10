
namespace NominasTrabajo.Formularios
{
    partial class FrmListaNominas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaNominas));
			this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.listView1 = new System.Windows.Forms.ListView();
			this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Mes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Año = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.TotalEmpleados = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.TotalNomina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.cmbBusqueda = new Guna.UI2.WinForms.Guna2ComboBox();
			this.lblBusqueda = new System.Windows.Forms.Label();
			this.cmbMeses = new Guna.UI2.WinForms.Guna2ComboBox();
			this.txtFinder = new Guna.UI2.WinForms.Guna2TextBox();
			this.btnFiltrar = new Guna.UI2.WinForms.Guna2GradientButton();
			this.guna2GradientPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// guna2BorderlessForm1
			// 
			this.guna2BorderlessForm1.ContainerControl = this;
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Mes,
            this.Año,
            this.TotalEmpleados,
            this.TotalNomina});
			this.listView1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(20, 177);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(768, 229);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.Click += new System.EventHandler(this.listView1_Click);
			// 
			// Id
			// 
			this.Id.Text = "Id";
			this.Id.Width = 70;
			// 
			// Mes
			// 
			this.Mes.Text = "Mes";
			this.Mes.Width = 220;
			// 
			// Año
			// 
			this.Año.Text = "Año";
			this.Año.Width = 120;
			// 
			// TotalEmpleados
			// 
			this.TotalEmpleados.Text = "Empleados";
			this.TotalEmpleados.Width = 130;
			// 
			// TotalNomina
			// 
			this.TotalNomina.Text = "Total Nomina";
			this.TotalNomina.Width = 210;
			// 
			// guna2GradientPanel1
			// 
			this.guna2GradientPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
			this.guna2GradientPanel1.Controls.Add(this.pictureBox1);
			this.guna2GradientPanel1.Controls.Add(this.pictureBox3);
			this.guna2GradientPanel1.Controls.Add(this.lblTitulo);
			this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(132)))), ((int)(((byte)(4)))));
			this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(253)))), ((int)(((byte)(4)))));
			this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
			this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
			this.guna2GradientPanel1.Name = "guna2GradientPanel1";
			this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
			this.guna2GradientPanel1.Size = new System.Drawing.Size(800, 85);
			this.guna2GradientPanel1.TabIndex = 1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(762, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(35, 28);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 14;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(733, 3);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(23, 28);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 13;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Franklin Gothic Book", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.White;
			this.lblTitulo.Location = new System.Drawing.Point(268, 38);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(275, 37);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Lista de nóminas ";
			// 
			// cmbBusqueda
			// 
			this.cmbBusqueda.BackColor = System.Drawing.Color.Transparent;
			this.cmbBusqueda.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.cmbBusqueda.BorderRadius = 10;
			this.cmbBusqueda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbBusqueda.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cmbBusqueda.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cmbBusqueda.FocusedState.Parent = this.cmbBusqueda;
			this.cmbBusqueda.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cmbBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cmbBusqueda.HoverState.Parent = this.cmbBusqueda;
			this.cmbBusqueda.ItemHeight = 30;
			this.cmbBusqueda.ItemsAppearance.Parent = this.cmbBusqueda;
			this.cmbBusqueda.Location = new System.Drawing.Point(55, 117);
			this.cmbBusqueda.Name = "cmbBusqueda";
			this.cmbBusqueda.ShadowDecoration.Parent = this.cmbBusqueda;
			this.cmbBusqueda.Size = new System.Drawing.Size(217, 36);
			this.cmbBusqueda.TabIndex = 2;
			this.cmbBusqueda.SelectedIndexChanged += new System.EventHandler(this.cmbBusqueda_SelectedIndexChanged);
			// 
			// lblBusqueda
			// 
			this.lblBusqueda.AutoSize = true;
			this.lblBusqueda.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBusqueda.Location = new System.Drawing.Point(77, 88);
			this.lblBusqueda.Name = "lblBusqueda";
			this.lblBusqueda.Size = new System.Drawing.Size(98, 26);
			this.lblBusqueda.TabIndex = 3;
			this.lblBusqueda.Text = "Filtrar por: ";
			// 
			// cmbMeses
			// 
			this.cmbMeses.BackColor = System.Drawing.Color.Transparent;
			this.cmbMeses.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.cmbMeses.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbMeses.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cmbMeses.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cmbMeses.FocusedState.Parent = this.cmbMeses;
			this.cmbMeses.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cmbMeses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cmbMeses.HoverState.Parent = this.cmbMeses;
			this.cmbMeses.ItemHeight = 30;
			this.cmbMeses.ItemsAppearance.Parent = this.cmbMeses;
			this.cmbMeses.Location = new System.Drawing.Point(305, 117);
			this.cmbMeses.Name = "cmbMeses";
			this.cmbMeses.ShadowDecoration.Parent = this.cmbMeses;
			this.cmbMeses.Size = new System.Drawing.Size(200, 36);
			this.cmbMeses.TabIndex = 4;
			this.cmbMeses.Visible = false;
			// 
			// txtFinder
			// 
			this.txtFinder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.txtFinder.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtFinder.DefaultText = "";
			this.txtFinder.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtFinder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtFinder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtFinder.DisabledState.Parent = this.txtFinder;
			this.txtFinder.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtFinder.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtFinder.FocusedState.Parent = this.txtFinder;
			this.txtFinder.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtFinder.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtFinder.HoverState.Parent = this.txtFinder;
			this.txtFinder.Location = new System.Drawing.Point(305, 117);
			this.txtFinder.Name = "txtFinder";
			this.txtFinder.PasswordChar = '\0';
			this.txtFinder.PlaceholderText = "";
			this.txtFinder.SelectedText = "";
			this.txtFinder.ShadowDecoration.Parent = this.txtFinder;
			this.txtFinder.Size = new System.Drawing.Size(200, 36);
			this.txtFinder.TabIndex = 5;
			this.txtFinder.Visible = false;
			this.txtFinder.TextChanged += new System.EventHandler(this.txtFinder_TextChanged);
			this.txtFinder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFinder_KeyPress);
			// 
			// btnFiltrar
			// 
			this.btnFiltrar.BorderRadius = 8;
			this.btnFiltrar.CheckedState.Parent = this.btnFiltrar;
			this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnFiltrar.CustomImages.Parent = this.btnFiltrar;
			this.btnFiltrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnFiltrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnFiltrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnFiltrar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnFiltrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnFiltrar.DisabledState.Parent = this.btnFiltrar;
			this.btnFiltrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnFiltrar.FillColor2 = System.Drawing.Color.Yellow;
			this.btnFiltrar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFiltrar.ForeColor = System.Drawing.Color.White;
			this.btnFiltrar.HoverState.Parent = this.btnFiltrar;
			this.btnFiltrar.Location = new System.Drawing.Point(545, 117);
			this.btnFiltrar.Name = "btnFiltrar";
			this.btnFiltrar.ShadowDecoration.Parent = this.btnFiltrar;
			this.btnFiltrar.Size = new System.Drawing.Size(176, 36);
			this.btnFiltrar.TabIndex = 14;
			this.btnFiltrar.Text = "FILTRAR";
			this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
			// 
			// FrmListaNominas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnFiltrar);
			this.Controls.Add(this.txtFinder);
			this.Controls.Add(this.cmbMeses);
			this.Controls.Add(this.lblBusqueda);
			this.Controls.Add(this.cmbBusqueda);
			this.Controls.Add(this.guna2GradientPanel1);
			this.Controls.Add(this.listView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmListaNominas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmListaNominas";
			this.Load += new System.EventHandler(this.FrmListaNominas_Load);
			this.guna2GradientPanel1.ResumeLayout(false);
			this.guna2GradientPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.ListView listView1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Mes;
        private System.Windows.Forms.ColumnHeader Año;
        private System.Windows.Forms.ColumnHeader TotalEmpleados;
        private Guna.UI2.WinForms.Guna2ComboBox cmbBusqueda;
        private System.Windows.Forms.Label lblBusqueda;
        private Guna.UI2.WinForms.Guna2TextBox txtFinder;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMeses;
        private Guna.UI2.WinForms.Guna2GradientButton btnFiltrar;
        private System.Windows.Forms.ColumnHeader TotalNomina;
    }
}