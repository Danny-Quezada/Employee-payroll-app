
namespace NominasTrabajo.Formularios
{
    partial class Mes_inicial
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
            this.cmbMeses = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // cmbMeses
            // 
            this.cmbMeses.BackColor = System.Drawing.Color.Transparent;
            this.cmbMeses.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmbMeses.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMeses.FocusedColor = System.Drawing.Color.Yellow;
            this.cmbMeses.FocusedState.BorderColor = System.Drawing.Color.Yellow;
            this.cmbMeses.FocusedState.Parent = this.cmbMeses;
            this.cmbMeses.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMeses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbMeses.HoverState.Parent = this.cmbMeses;
            this.cmbMeses.ItemHeight = 30;
            this.cmbMeses.ItemsAppearance.Parent = this.cmbMeses;
            this.cmbMeses.Location = new System.Drawing.Point(296, 164);
            this.cmbMeses.Name = "cmbMeses";
            this.cmbMeses.ShadowDecoration.BorderRadius = 7;
            this.cmbMeses.ShadowDecoration.Parent = this.cmbMeses;
            this.cmbMeses.Size = new System.Drawing.Size(174, 36);
            this.cmbMeses.TabIndex = 12;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(296, 156);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel1.TabIndex = 13;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(188, 80);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(433, 47);
            this.guna2HtmlLabel2.TabIndex = 14;
            this.guna2HtmlLabel2.Text = "Mes con que inicia la planilla";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BorderRadius = 8;
            this.btnAgregar.CheckedState.Parent = this.btnAgregar;
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
            this.btnAgregar.Location = new System.Drawing.Point(290, 251);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.ShadowDecoration.Parent = this.btnAgregar;
            this.btnAgregar.Size = new System.Drawing.Size(180, 45);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Aceptar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Mes_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.cmbMeses);
            this.Name = "Mes_inicial";
            this.Text = "Mes_inicial";
            this.Load += new System.EventHandler(this.Mes_inicial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cmbMeses;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2GradientButton btnAgregar;
    }
}