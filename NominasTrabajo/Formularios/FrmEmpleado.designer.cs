
namespace NominasTrabajo
{
	partial class FrmEmpleado
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleado));
			this.txtNombre = new RJCodeAdvance.RJControls.RJTextBox();
			this.txtSalario = new RJCodeAdvance.RJControls.RJTextBox();
			this.PBImagen = new RJCodeAdvance.RJControls.RJCircularPictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pbWaves = new System.Windows.Forms.PictureBox();
			this.txtCodigoInss = new RJCodeAdvance.RJControls.RJTextBox();
			this.txtHorasTrabajadas = new RJCodeAdvance.RJControls.RJTextBox();
			this.btnAgregar = new Guna.UI2.WinForms.Guna2GradientButton();
			this.label1 = new System.Windows.Forms.Label();
			this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.cmbCargos = new Guna.UI2.WinForms.Guna2ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnRecontratar = new Guna.UI2.WinForms.Guna2ImageButton();
			((System.ComponentModel.ISupportInitialize)(this.PBImagen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbWaves)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// txtNombre
			// 
			this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
			this.txtNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.txtNombre.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.txtNombre.BorderRadius = 10;
			this.txtNombre.BorderSize = 2;
			this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.ForeColor = System.Drawing.Color.Gray;
			this.txtNombre.Location = new System.Drawing.Point(507, 176);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
			this.txtNombre.Multiline = false;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.txtNombre.PasswordChar = false;
			this.txtNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.txtNombre.PlaceholderText = "Nombre";
			this.txtNombre.Size = new System.Drawing.Size(232, 35);
			this.txtNombre.TabIndex = 1;
			this.txtNombre.Texts = "";
			this.txtNombre.UnderlinedStyle = true;
			this.txtNombre._TextChanged += new System.EventHandler(this.txtNombre__TextChanged);
			// 
			// txtSalario
			// 
			this.txtSalario.BackColor = System.Drawing.SystemColors.Window;
			this.txtSalario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.txtSalario.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.txtSalario.BorderRadius = 10;
			this.txtSalario.BorderSize = 2;
			this.txtSalario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSalario.ForeColor = System.Drawing.Color.Gray;
			this.txtSalario.Location = new System.Drawing.Point(507, 303);
			this.txtSalario.Margin = new System.Windows.Forms.Padding(4);
			this.txtSalario.Multiline = false;
			this.txtSalario.Name = "txtSalario";
			this.txtSalario.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.txtSalario.PasswordChar = false;
			this.txtSalario.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.txtSalario.PlaceholderText = "Salario";
			this.txtSalario.Size = new System.Drawing.Size(232, 35);
			this.txtSalario.TabIndex = 5;
			this.txtSalario.Texts = "";
			this.txtSalario.UnderlinedStyle = true;
			this.txtSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalario_KeyPress);
			// 
			// PBImagen
			// 
			this.PBImagen.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
			this.PBImagen.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.PBImagen.BorderColor2 = System.Drawing.Color.Yellow;
			this.PBImagen.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
			this.PBImagen.BorderSize = 2;
			this.PBImagen.Cursor = System.Windows.Forms.Cursors.Hand;
			this.PBImagen.GradientAngle = 50F;
			this.PBImagen.Image = ((System.Drawing.Image)(resources.GetObject("PBImagen.Image")));
			this.PBImagen.Location = new System.Drawing.Point(360, 214);
			this.PBImagen.Name = "PBImagen";
			this.PBImagen.Size = new System.Drawing.Size(100, 100);
			this.PBImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.PBImagen.TabIndex = 4;
			this.PBImagen.TabStop = false;
			this.PBImagen.Click += new System.EventHandler(this.PBImagen_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(-30, 151);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(443, 337);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// pbWaves
			// 
			this.pbWaves.Image = ((System.Drawing.Image)(resources.GetObject("pbWaves.Image")));
			this.pbWaves.Location = new System.Drawing.Point(0, 0);
			this.pbWaves.Name = "pbWaves";
			this.pbWaves.Size = new System.Drawing.Size(800, 215);
			this.pbWaves.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbWaves.TabIndex = 0;
			this.pbWaves.TabStop = false;
			this.pbWaves.Click += new System.EventHandler(this.pbWaves_Click);
			// 
			// txtCodigoInss
			// 
			this.txtCodigoInss.BackColor = System.Drawing.SystemColors.Window;
			this.txtCodigoInss.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.txtCodigoInss.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.txtCodigoInss.BorderRadius = 10;
			this.txtCodigoInss.BorderSize = 2;
			this.txtCodigoInss.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCodigoInss.ForeColor = System.Drawing.Color.Gray;
			this.txtCodigoInss.Location = new System.Drawing.Point(507, 240);
			this.txtCodigoInss.Margin = new System.Windows.Forms.Padding(4);
			this.txtCodigoInss.Multiline = false;
			this.txtCodigoInss.Name = "txtCodigoInss";
			this.txtCodigoInss.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.txtCodigoInss.PasswordChar = false;
			this.txtCodigoInss.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.txtCodigoInss.PlaceholderText = "Código INSS";
			this.txtCodigoInss.Size = new System.Drawing.Size(232, 35);
			this.txtCodigoInss.TabIndex = 3;
			this.txtCodigoInss.Texts = "";
			this.txtCodigoInss.UnderlinedStyle = true;
			this.txtCodigoInss.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoInss_KeyPress);
			// 
			// txtHorasTrabajadas
			// 
			this.txtHorasTrabajadas.BackColor = System.Drawing.SystemColors.Window;
			this.txtHorasTrabajadas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.txtHorasTrabajadas.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.txtHorasTrabajadas.BorderRadius = 10;
			this.txtHorasTrabajadas.BorderSize = 2;
			this.txtHorasTrabajadas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHorasTrabajadas.ForeColor = System.Drawing.Color.Gray;
			this.txtHorasTrabajadas.Location = new System.Drawing.Point(507, 360);
			this.txtHorasTrabajadas.Margin = new System.Windows.Forms.Padding(4);
			this.txtHorasTrabajadas.Multiline = false;
			this.txtHorasTrabajadas.Name = "txtHorasTrabajadas";
			this.txtHorasTrabajadas.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.txtHorasTrabajadas.PasswordChar = false;
			this.txtHorasTrabajadas.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.txtHorasTrabajadas.PlaceholderText = "Horas Extra";
			this.txtHorasTrabajadas.Size = new System.Drawing.Size(232, 35);
			this.txtHorasTrabajadas.TabIndex = 6;
			this.txtHorasTrabajadas.Texts = "";
			this.txtHorasTrabajadas.UnderlinedStyle = true;
			this.txtHorasTrabajadas._TextChanged += new System.EventHandler(this.txtHorasTrabajadas__TextChanged);
			this.txtHorasTrabajadas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHorasTrabajadas_KeyPress);
			// 
			// btnAgregar
			// 
			this.btnAgregar.BorderRadius = 8;
			this.btnAgregar.CheckedState.Parent = this.btnAgregar;
			this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAgregar.CustomImages.Parent = this.btnAgregar;
			this.btnAgregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnAgregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnAgregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnAgregar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnAgregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnAgregar.DisabledState.Parent = this.btnAgregar;
			this.btnAgregar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnAgregar.FillColor2 = System.Drawing.Color.Yellow;
			this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnAgregar.ForeColor = System.Drawing.Color.White;
			this.btnAgregar.HoverState.Parent = this.btnAgregar;
			this.btnAgregar.Location = new System.Drawing.Point(534, 425);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.ShadowDecoration.Parent = this.btnAgregar;
			this.btnAgregar.Size = new System.Drawing.Size(180, 45);
			this.btnAgregar.TabIndex = 7;
			this.btnAgregar.Text = "AGREGAR";
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Gray;
			this.label1.Location = new System.Drawing.Point(357, 194);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 17);
			this.label1.TabIndex = 8;
			this.label1.Text = "Foto del empleado";
			// 
			// guna2BorderlessForm1
			// 
			this.guna2BorderlessForm1.BorderRadius = 10;
			this.guna2BorderlessForm1.ContainerControl = this;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(117)))), ((int)(((byte)(54)))));
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(765, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(35, 28);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(117)))), ((int)(((byte)(54)))));
			this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(736, 0);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(23, 28);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 10;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
			// 
			// cmbCargos
			// 
			this.cmbCargos.BackColor = System.Drawing.Color.Transparent;
			this.cmbCargos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.cmbCargos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbCargos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCargos.FocusedColor = System.Drawing.Color.Yellow;
			this.cmbCargos.FocusedState.BorderColor = System.Drawing.Color.Yellow;
			this.cmbCargos.FocusedState.Parent = this.cmbCargos;
			this.cmbCargos.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cmbCargos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cmbCargos.HoverState.Parent = this.cmbCargos;
			this.cmbCargos.ItemHeight = 30;
			this.cmbCargos.ItemsAppearance.Parent = this.cmbCargos;
			this.cmbCargos.Location = new System.Drawing.Point(336, 359);
			this.cmbCargos.Name = "cmbCargos";
			this.cmbCargos.ShadowDecoration.BorderRadius = 7;
			this.cmbCargos.ShadowDecoration.Parent = this.cmbCargos;
			this.cmbCargos.Size = new System.Drawing.Size(140, 36);
			this.cmbCargos.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Gray;
			this.label2.Location = new System.Drawing.Point(380, 339);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 17);
			this.label2.TabIndex = 12;
			this.label2.Text = "Cargos";
			// 
			// btnRecontratar
			// 
			this.btnRecontratar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnRecontratar.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
			this.btnRecontratar.CheckedState.Parent = this.btnRecontratar;
			this.btnRecontratar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRecontratar.HoverState.ImageSize = new System.Drawing.Size(60, 60);
			this.btnRecontratar.HoverState.Parent = this.btnRecontratar;
			this.btnRecontratar.Image = ((System.Drawing.Image)(resources.GetObject("btnRecontratar.Image")));
			this.btnRecontratar.ImageOffset = new System.Drawing.Point(0, 0);
			this.btnRecontratar.ImageRotate = 0F;
			this.btnRecontratar.Location = new System.Drawing.Point(374, 402);
			this.btnRecontratar.Name = "btnRecontratar";
			this.btnRecontratar.PressedState.ImageSize = new System.Drawing.Size(64, 64);
			this.btnRecontratar.PressedState.Parent = this.btnRecontratar;
			this.btnRecontratar.ShadowDecoration.Parent = this.btnRecontratar;
			this.btnRecontratar.Size = new System.Drawing.Size(71, 68);
			this.btnRecontratar.TabIndex = 13;
			this.btnRecontratar.Visible = false;
			this.btnRecontratar.Click += new System.EventHandler(this.btnRecontratar_Click);
			// 
			// FrmEmpleado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(800, 500);
			this.Controls.Add(this.btnRecontratar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cmbCargos);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.txtHorasTrabajadas);
			this.Controls.Add(this.txtCodigoInss);
			this.Controls.Add(this.PBImagen);
			this.Controls.Add(this.txtSalario);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pbWaves);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(800, 500);
			this.MinimumSize = new System.Drawing.Size(800, 500);
			this.Name = "FrmEmpleado";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Empleados";
			this.Load += new System.EventHandler(this.FrmEmpleado_Load);
			((System.ComponentModel.ISupportInitialize)(this.PBImagen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbWaves)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pbWaves;
		private System.Windows.Forms.PictureBox pictureBox2;
		private RJCodeAdvance.RJControls.RJTextBox txtNombre;
		private RJCodeAdvance.RJControls.RJTextBox txtSalario;
		private RJCodeAdvance.RJControls.RJCircularPictureBox PBImagen;
		private RJCodeAdvance.RJControls.RJTextBox txtHorasTrabajadas;
		private RJCodeAdvance.RJControls.RJTextBox txtCodigoInss;
		private Guna.UI2.WinForms.Guna2GradientButton btnAgregar;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private Guna.UI2.WinForms.Guna2ComboBox cmbCargos;
		private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2ImageButton btnRecontratar;
	}
}