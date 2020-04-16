namespace Talent
{
    partial class Empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleados));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.datos = new System.Windows.Forms.DataGridView();
            this.btnLIniciarSesion = new Bunifu.Framework.UI.BunifuThinButton2();
            this.buscar = new System.Windows.Forms.PictureBox();
            this.empleado = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnAAgregar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(166)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1380, 49);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "Empleados";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Talent.Properties.Resources.cerrarsesion;
            this.pictureBox1.Location = new System.Drawing.Point(8, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // datos
            // 
            this.datos.AllowUserToAddRows = false;
            this.datos.AllowUserToDeleteRows = false;
            this.datos.AllowUserToResizeColumns = false;
            this.datos.AllowUserToResizeRows = false;
            this.datos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datos.BackgroundColor = System.Drawing.Color.White;
            this.datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datos.Cursor = System.Windows.Forms.Cursors.Default;
            this.datos.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.datos.Location = new System.Drawing.Point(0, 122);
            this.datos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datos.Name = "datos";
            this.datos.ReadOnly = true;
            this.datos.RowHeadersWidth = 51;
            this.datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datos.Size = new System.Drawing.Size(1380, 577);
            this.datos.TabIndex = 221;
            // 
            // btnLIniciarSesion
            // 
            this.btnLIniciarSesion.ActiveBorderThickness = 1;
            this.btnLIniciarSesion.ActiveCornerRadius = 20;
            this.btnLIniciarSesion.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnLIniciarSesion.ActiveForecolor = System.Drawing.Color.White;
            this.btnLIniciarSesion.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnLIniciarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLIniciarSesion.BackColor = System.Drawing.Color.White;
            this.btnLIniciarSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLIniciarSesion.BackgroundImage")));
            this.btnLIniciarSesion.ButtonText = "Ver Información";
            this.btnLIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLIniciarSesion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLIniciarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnLIniciarSesion.IdleBorderThickness = 1;
            this.btnLIniciarSesion.IdleCornerRadius = 20;
            this.btnLIniciarSesion.IdleFillColor = System.Drawing.Color.White;
            this.btnLIniciarSesion.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnLIniciarSesion.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnLIniciarSesion.Location = new System.Drawing.Point(8, 709);
            this.btnLIniciarSesion.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnLIniciarSesion.Name = "btnLIniciarSesion";
            this.btnLIniciarSesion.Size = new System.Drawing.Size(209, 50);
            this.btnLIniciarSesion.TabIndex = 228;
            this.btnLIniciarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLIniciarSesion.Click += new System.EventHandler(this.btnLIniciarSesion_Click);
            // 
            // buscar
            // 
            this.buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscar.Image = global::Talent.Properties.Resources.buscar;
            this.buscar.Location = new System.Drawing.Point(339, 74);
            this.buscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(31, 27);
            this.buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buscar.TabIndex = 227;
            this.buscar.TabStop = false;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // empleado
            // 
            this.empleado.BackColor = System.Drawing.Color.White;
            this.empleado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("empleado.BackgroundImage")));
            this.empleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.empleado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.empleado.Icon = ((System.Drawing.Image)(resources.GetObject("empleado.Icon")));
            this.empleado.Location = new System.Drawing.Point(8, 66);
            this.empleado.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.empleado.Name = "empleado";
            this.empleado.Size = new System.Drawing.Size(323, 38);
            this.empleado.TabIndex = 226;
            this.empleado.text = "";
            // 
            // btnAAgregar
            // 
            this.btnAAgregar.ActiveBorderThickness = 1;
            this.btnAAgregar.ActiveCornerRadius = 20;
            this.btnAAgregar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnAAgregar.ActiveForecolor = System.Drawing.Color.White;
            this.btnAAgregar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnAAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAAgregar.BackColor = System.Drawing.Color.White;
            this.btnAAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAAgregar.BackgroundImage")));
            this.btnAAgregar.ButtonText = "Registrar empleado";
            this.btnAAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnAAgregar.IdleBorderThickness = 1;
            this.btnAAgregar.IdleCornerRadius = 20;
            this.btnAAgregar.IdleFillColor = System.Drawing.Color.White;
            this.btnAAgregar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnAAgregar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnAAgregar.Location = new System.Drawing.Point(1137, 55);
            this.btnAAgregar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnAAgregar.Name = "btnAAgregar";
            this.btnAAgregar.Size = new System.Drawing.Size(233, 50);
            this.btnAAgregar.TabIndex = 222;
            this.btnAAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAAgregar.Click += new System.EventHandler(this.btnAAgregar_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.bunifuThinButton21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Registrar RH";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(231, 708);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(160, 50);
            this.bunifuThinButton21.TabIndex = 229;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1380, 775);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.btnLIniciarSesion);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.empleado);
            this.Controls.Add(this.btnAAgregar);
            this.Controls.Add(this.datos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Empleados_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAAgregar;
        private System.Windows.Forms.DataGridView datos;
        private System.Windows.Forms.PictureBox buscar;
        private Bunifu.Framework.UI.BunifuTextbox empleado;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLIniciarSesion;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
    }
}