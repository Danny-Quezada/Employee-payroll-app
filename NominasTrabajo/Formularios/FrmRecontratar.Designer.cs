
namespace NominasTrabajo.Formularios
{
	partial class FrmRecontratar
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecontratar));
			this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
			this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NUMINSS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.txtBuscar = new RJCodeAdvance.RJControls.RJTextBox();
			this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
			this.btnRecontratar = new Guna.UI2.WinForms.Guna2ImageButton();
			this.btnModificar = new Guna.UI2.WinForms.Guna2ImageButton();
			this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// guna2BorderlessForm1
			// 
			this.guna2BorderlessForm1.BorderRadius = 15;
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockForm = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(736, 12);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(23, 22);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(765, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(23, 22);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// guna2DataGridView1
			// 
			this.guna2DataGridView1.AllowUserToAddRows = false;
			this.guna2DataGridView1.AllowUserToDeleteRows = false;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.guna2DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.guna2DataGridView1.ColumnHeadersHeight = 59;
			this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.NUMINSS,
            this.Nombre,
            this.Cargo,
            this.Sueldo});
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
			this.guna2DataGridView1.EnableHeadersVisualStyles = false;
			this.guna2DataGridView1.GridColor = System.Drawing.Color.White;
			this.guna2DataGridView1.Location = new System.Drawing.Point(12, 74);
			this.guna2DataGridView1.Name = "guna2DataGridView1";
			this.guna2DataGridView1.ReadOnly = true;
			this.guna2DataGridView1.RowHeadersVisible = false;
			this.guna2DataGridView1.RowTemplate.DividerHeight = 2;
			this.guna2DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.guna2DataGridView1.Size = new System.Drawing.Size(652, 374);
			this.guna2DataGridView1.TabIndex = 2;
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
			this.guna2DataGridView1.DoubleClick += new System.EventHandler(this.guna2DataGridView1_DoubleClick);
			// 
			// Numero
			// 
			this.Numero.FillWeight = 70.94655F;
			this.Numero.HeaderText = "Número";
			this.Numero.Name = "Numero";
			this.Numero.ReadOnly = true;
			// 
			// NUMINSS
			// 
			this.NUMINSS.FillWeight = 70.94655F;
			this.NUMINSS.HeaderText = "Número INSS";
			this.NUMINSS.Name = "NUMINSS";
			this.NUMINSS.ReadOnly = true;
			// 
			// Nombre
			// 
			this.Nombre.FillWeight = 70.94655F;
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			// 
			// Cargo
			// 
			this.Cargo.FillWeight = 70.94655F;
			this.Cargo.HeaderText = "Cargo";
			this.Cargo.Name = "Cargo";
			this.Cargo.ReadOnly = true;
			// 
			// Sueldo
			// 
			this.Sueldo.FillWeight = 70.94655F;
			this.Sueldo.HeaderText = "Sueldo";
			this.Sueldo.Name = "Sueldo";
			this.Sueldo.ReadOnly = true;
			// 
			// guna2Elipse1
			// 
			this.guna2Elipse1.BorderRadius = 10;
			this.guna2Elipse1.TargetControl = this.guna2DataGridView1;
			// 
			// txtBuscar
			// 
			this.txtBuscar.BackColor = System.Drawing.SystemColors.Window;
			this.txtBuscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(152)))), ((int)(((byte)(248)))));
			this.txtBuscar.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(213)))), ((int)(((byte)(252)))));
			this.txtBuscar.BorderRadius = 0;
			this.txtBuscar.BorderSize = 2;
			this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtBuscar.Location = new System.Drawing.Point(38, 26);
			this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
			this.txtBuscar.Multiline = false;
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.txtBuscar.PasswordChar = false;
			this.txtBuscar.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.txtBuscar.PlaceholderText = "";
			this.txtBuscar.Size = new System.Drawing.Size(250, 31);
			this.txtBuscar.TabIndex = 3;
			this.txtBuscar.Texts = "";
			this.txtBuscar.UnderlinedStyle = true;
			this.txtBuscar.Visible = false;
			this.txtBuscar._TextChanged += new System.EventHandler(this.txtBuscar__TextChanged);
			this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
			this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
			// 
			// guna2ComboBox1
			// 
			this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
			this.guna2ComboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.guna2ComboBox1.FocusedState.Parent = this.guna2ComboBox1;
			this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.guna2ComboBox1.HoverState.Parent = this.guna2ComboBox1;
			this.guna2ComboBox1.ItemHeight = 30;
			this.guna2ComboBox1.ItemsAppearance.Parent = this.guna2ComboBox1;
			this.guna2ComboBox1.Location = new System.Drawing.Point(323, 21);
			this.guna2ComboBox1.Name = "guna2ComboBox1";
			this.guna2ComboBox1.ShadowDecoration.Parent = this.guna2ComboBox1;
			this.guna2ComboBox1.Size = new System.Drawing.Size(140, 36);
			this.guna2ComboBox1.TabIndex = 4;
			this.guna2ComboBox1.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
			// 
			// btnRecontratar
			// 
			this.btnRecontratar.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
			this.btnRecontratar.CheckedState.Parent = this.btnRecontratar;
			this.btnRecontratar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRecontratar.HoverState.ImageSize = new System.Drawing.Size(59, 59);
			this.btnRecontratar.HoverState.Parent = this.btnRecontratar;
			this.btnRecontratar.Image = ((System.Drawing.Image)(resources.GetObject("btnRecontratar.Image")));
			this.btnRecontratar.ImageOffset = new System.Drawing.Point(0, 0);
			this.btnRecontratar.ImageRotate = 0F;
			this.btnRecontratar.Location = new System.Drawing.Point(696, 134);
			this.btnRecontratar.Name = "btnRecontratar";
			this.btnRecontratar.PressedState.ImageSize = new System.Drawing.Size(64, 64);
			this.btnRecontratar.PressedState.Parent = this.btnRecontratar;
			this.btnRecontratar.ShadowDecoration.Parent = this.btnRecontratar;
			this.btnRecontratar.Size = new System.Drawing.Size(78, 78);
			this.btnRecontratar.TabIndex = 5;
			this.btnRecontratar.Visible = false;
			this.btnRecontratar.Click += new System.EventHandler(this.btnRecontratar_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
			this.btnModificar.CheckedState.Parent = this.btnModificar;
			this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnModificar.HoverState.ImageSize = new System.Drawing.Size(64, 64);
			this.btnModificar.HoverState.Parent = this.btnModificar;
			this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
			this.btnModificar.ImageOffset = new System.Drawing.Point(0, 0);
			this.btnModificar.ImageRotate = 0F;
			this.btnModificar.Location = new System.Drawing.Point(696, 300);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.PressedState.ImageSize = new System.Drawing.Size(64, 64);
			this.btnModificar.PressedState.Parent = this.btnModificar;
			this.btnModificar.ShadowDecoration.Parent = this.btnModificar;
			this.btnModificar.Size = new System.Drawing.Size(78, 77);
			this.btnModificar.TabIndex = 6;
			this.btnModificar.Visible = false;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// guna2GradientButton1
			// 
			this.guna2GradientButton1.BorderRadius = 17;
			this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
			this.guna2GradientButton1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
			this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2GradientButton1.DisabledState.Parent = this.guna2GradientButton1;
			this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(152)))), ((int)(((byte)(248)))));
			this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(213)))), ((int)(((byte)(252)))));
			this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
			this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
			this.guna2GradientButton1.Location = new System.Drawing.Point(499, 21);
			this.guna2GradientButton1.Name = "guna2GradientButton1";
			this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
			this.guna2GradientButton1.Size = new System.Drawing.Size(110, 36);
			this.guna2GradientButton1.TabIndex = 7;
			this.guna2GradientButton1.Text = "F i l t r a r";
			this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
			// 
			// FrmRecontratar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.guna2GradientButton1);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnRecontratar);
			this.Controls.Add(this.guna2ComboBox1);
			this.Controls.Add(this.txtBuscar);
			this.Controls.Add(this.guna2DataGridView1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(800, 450);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(800, 450);
			this.Name = "FrmRecontratar";
			this.Text = "FrmRecontratar";
			this.Load += new System.EventHandler(this.FrmRecontratar_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
		private RJCodeAdvance.RJControls.RJTextBox txtBuscar;
		private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
		private System.Windows.Forms.DataGridViewTextBoxColumn NUMINSS;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sueldo;
		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
		private Guna.UI2.WinForms.Guna2ImageButton btnModificar;
		private Guna.UI2.WinForms.Guna2ImageButton btnRecontratar;
		private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
		private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
	}
}