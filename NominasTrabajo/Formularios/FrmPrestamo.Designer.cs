
namespace NominasTrabajo.Formularios
{
    partial class FrmPrestamo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrestamo));
			this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblPrestamo = new System.Windows.Forms.Label();
			this.cmbTiempo = new Guna.UI2.WinForms.Guna2ComboBox();
			this.txtId = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtNoINSS = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtSalario = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
			this.lblDatos = new System.Windows.Forms.Label();
			this.txtPrestamo = new RJCodeAdvance.RJControls.RJTextBox();
			this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.guna2GradientPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// guna2GradientPanel1
			// 
			this.guna2GradientPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
			this.guna2GradientPanel1.Controls.Add(this.pictureBox2);
			this.guna2GradientPanel1.Controls.Add(this.pictureBox1);
			this.guna2GradientPanel1.Controls.Add(this.lblPrestamo);
			this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(131)))));
			this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(209)))), ((int)(((byte)(20)))));
			this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
			this.guna2GradientPanel1.Name = "guna2GradientPanel1";
			this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
			this.guna2GradientPanel1.Size = new System.Drawing.Size(800, 80);
			this.guna2GradientPanel1.TabIndex = 0;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(546, 2);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(20, 23);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(572, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(22, 22);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// lblPrestamo
			// 
			this.lblPrestamo.AutoSize = true;
			this.lblPrestamo.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrestamo.ForeColor = System.Drawing.Color.White;
			this.lblPrestamo.Location = new System.Drawing.Point(212, 20);
			this.lblPrestamo.Name = "lblPrestamo";
			this.lblPrestamo.Size = new System.Drawing.Size(176, 37);
			this.lblPrestamo.TabIndex = 0;
			this.lblPrestamo.Text = "P r e s t a m o";
			// 
			// cmbTiempo
			// 
			this.cmbTiempo.BackColor = System.Drawing.Color.Transparent;
			this.cmbTiempo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(131)))));
			this.cmbTiempo.BorderRadius = 10;
			this.cmbTiempo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbTiempo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTiempo.DropDownWidth = 140;
			this.cmbTiempo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cmbTiempo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cmbTiempo.FocusedState.Parent = this.cmbTiempo;
			this.cmbTiempo.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cmbTiempo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cmbTiempo.HoverState.Parent = this.cmbTiempo;
			this.cmbTiempo.ItemHeight = 30;
			this.cmbTiempo.ItemsAppearance.Parent = this.cmbTiempo;
			this.cmbTiempo.Location = new System.Drawing.Point(374, 255);
			this.cmbTiempo.Name = "cmbTiempo";
			this.cmbTiempo.ShadowDecoration.Parent = this.cmbTiempo;
			this.cmbTiempo.Size = new System.Drawing.Size(148, 36);
			this.cmbTiempo.TabIndex = 2;
			this.cmbTiempo.SelectedIndexChanged += new System.EventHandler(this.cmbTiempo_SelectedIndexChanged);
			// 
			// txtId
			// 
			this.txtId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(131)))));
			this.txtId.BorderRadius = 18;
			this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtId.DefaultText = "ID";
			this.txtId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtId.DisabledState.Parent = this.txtId;
			this.txtId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtId.FocusedState.Parent = this.txtId;
			this.txtId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtId.HoverState.Parent = this.txtId;
			this.txtId.Location = new System.Drawing.Point(72, 166);
			this.txtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtId.Name = "txtId";
			this.txtId.PasswordChar = '\0';
			this.txtId.PlaceholderText = "";
			this.txtId.ReadOnly = true;
			this.txtId.SelectedText = "";
			this.txtId.SelectionStart = 2;
			this.txtId.ShadowDecoration.Parent = this.txtId;
			this.txtId.Size = new System.Drawing.Size(230, 35);
			this.txtId.TabIndex = 19;
			// 
			// txtNombre
			// 
			this.txtNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(131)))));
			this.txtNombre.BorderRadius = 18;
			this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtNombre.DefaultText = "Nombre";
			this.txtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtNombre.DisabledState.Parent = this.txtNombre;
			this.txtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtNombre.FocusedState.Parent = this.txtNombre;
			this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtNombre.HoverState.Parent = this.txtNombre;
			this.txtNombre.Location = new System.Drawing.Point(72, 225);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.PasswordChar = '\0';
			this.txtNombre.PlaceholderText = "";
			this.txtNombre.ReadOnly = true;
			this.txtNombre.SelectedText = "";
			this.txtNombre.SelectionStart = 6;
			this.txtNombre.ShadowDecoration.Parent = this.txtNombre;
			this.txtNombre.Size = new System.Drawing.Size(230, 35);
			this.txtNombre.TabIndex = 20;
			// 
			// txtNoINSS
			// 
			this.txtNoINSS.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(131)))));
			this.txtNoINSS.BorderRadius = 18;
			this.txtNoINSS.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtNoINSS.DefaultText = "Número de INSS";
			this.txtNoINSS.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtNoINSS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtNoINSS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtNoINSS.DisabledState.Parent = this.txtNoINSS;
			this.txtNoINSS.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtNoINSS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtNoINSS.FocusedState.Parent = this.txtNoINSS;
			this.txtNoINSS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNoINSS.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtNoINSS.HoverState.Parent = this.txtNoINSS;
			this.txtNoINSS.Location = new System.Drawing.Point(72, 282);
			this.txtNoINSS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtNoINSS.Name = "txtNoINSS";
			this.txtNoINSS.PasswordChar = '\0';
			this.txtNoINSS.PlaceholderText = "";
			this.txtNoINSS.ReadOnly = true;
			this.txtNoINSS.SelectedText = "";
			this.txtNoINSS.SelectionStart = 14;
			this.txtNoINSS.ShadowDecoration.Parent = this.txtNoINSS;
			this.txtNoINSS.Size = new System.Drawing.Size(230, 35);
			this.txtNoINSS.TabIndex = 21;
			// 
			// txtSalario
			// 
			this.txtSalario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(131)))));
			this.txtSalario.BorderRadius = 18;
			this.txtSalario.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtSalario.DefaultText = "Salario mensual";
			this.txtSalario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtSalario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtSalario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtSalario.DisabledState.Parent = this.txtSalario;
			this.txtSalario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtSalario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtSalario.FocusedState.Parent = this.txtSalario;
			this.txtSalario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSalario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtSalario.HoverState.Parent = this.txtSalario;
			this.txtSalario.Location = new System.Drawing.Point(72, 341);
			this.txtSalario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtSalario.Name = "txtSalario";
			this.txtSalario.PasswordChar = '\0';
			this.txtSalario.PlaceholderText = "";
			this.txtSalario.ReadOnly = true;
			this.txtSalario.SelectedText = "";
			this.txtSalario.SelectionStart = 15;
			this.txtSalario.ShadowDecoration.Parent = this.txtSalario;
			this.txtSalario.Size = new System.Drawing.Size(230, 35);
			this.txtSalario.TabIndex = 22;
			// 
			// guna2GradientButton1
			// 
			this.guna2GradientButton1.BorderRadius = 18;
			this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
			this.guna2GradientButton1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
			this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2GradientButton1.DisabledState.Parent = this.guna2GradientButton1;
			this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(131)))));
			this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(209)))), ((int)(((byte)(20)))));
			this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
			this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
			this.guna2GradientButton1.Location = new System.Drawing.Point(386, 331);
			this.guna2GradientButton1.Name = "guna2GradientButton1";
			this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
			this.guna2GradientButton1.Size = new System.Drawing.Size(124, 45);
			this.guna2GradientButton1.TabIndex = 23;
			this.guna2GradientButton1.Text = "A c e p t a r";
			this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
			// 
			// lblDatos
			// 
			this.lblDatos.AutoSize = true;
			this.lblDatos.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDatos.ForeColor = System.Drawing.Color.Silver;
			this.lblDatos.Location = new System.Drawing.Point(65, 102);
			this.lblDatos.Name = "lblDatos";
			this.lblDatos.Size = new System.Drawing.Size(249, 37);
			this.lblDatos.TabIndex = 24;
			this.lblDatos.Text = "Datos del empleado";
			// 
			// txtPrestamo
			// 
			this.txtPrestamo.BackColor = System.Drawing.SystemColors.Window;
			this.txtPrestamo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(131)))));
			this.txtPrestamo.BorderFocusColor = System.Drawing.Color.Green;
			this.txtPrestamo.BorderRadius = 10;
			this.txtPrestamo.BorderSize = 2;
			this.txtPrestamo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrestamo.ForeColor = System.Drawing.Color.DimGray;
			this.txtPrestamo.Location = new System.Drawing.Point(374, 189);
			this.txtPrestamo.Margin = new System.Windows.Forms.Padding(4);
			this.txtPrestamo.Multiline = false;
			this.txtPrestamo.Name = "txtPrestamo";
			this.txtPrestamo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.txtPrestamo.PasswordChar = false;
			this.txtPrestamo.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.txtPrestamo.PlaceholderText = "Monto del Prestamo";
			this.txtPrestamo.Size = new System.Drawing.Size(166, 35);
			this.txtPrestamo.TabIndex = 32;
			this.txtPrestamo.Texts = "";
			this.txtPrestamo.UnderlinedStyle = true;
			this.txtPrestamo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrestamo_KeyPress);
			// 
			// guna2Elipse1
			// 
			this.guna2Elipse1.BorderRadius = 10;
			this.guna2Elipse1.TargetControl = this;
			// 
			// guna2BorderlessForm1
			// 
			this.guna2BorderlessForm1.BorderRadius = 20;
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockForm = false;
			// 
			// FrmPrestamo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(600, 450);
			this.Controls.Add(this.txtPrestamo);
			this.Controls.Add(this.lblDatos);
			this.Controls.Add(this.guna2GradientButton1);
			this.Controls.Add(this.txtSalario);
			this.Controls.Add(this.txtNoINSS);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.cmbTiempo);
			this.Controls.Add(this.guna2GradientPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximumSize = new System.Drawing.Size(600, 450);
			this.MinimumSize = new System.Drawing.Size(600, 450);
			this.Name = "FrmPrestamo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Prestamo";
			this.Load += new System.EventHandler(this.FrmPrestamo_Load);
			this.guna2GradientPanel1.ResumeLayout(false);
			this.guna2GradientPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label lblPrestamo;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTiempo;
        private Guna.UI2.WinForms.Guna2TextBox txtId;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private Guna.UI2.WinForms.Guna2TextBox txtNoINSS;
        private Guna.UI2.WinForms.Guna2TextBox txtSalario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private System.Windows.Forms.Label lblDatos;
        private RJCodeAdvance.RJControls.RJTextBox txtPrestamo;
		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
		private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
	}
}