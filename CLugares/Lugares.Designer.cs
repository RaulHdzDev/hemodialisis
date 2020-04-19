namespace Talent
{
    partial class Lugares
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lugares));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.datos = new System.Windows.Forms.DataGridView();
            this.btnAAgregar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label14 = new System.Windows.Forms.Label();
            this.lugar = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.buscar = new System.Windows.Forms.PictureBox();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 40);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Camillas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Talent.Properties.Resources.cerrarsesion;
            this.pictureBox1.Location = new System.Drawing.Point(6, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // datos
            // 
            this.datos.AllowUserToAddRows = false;
            this.datos.AllowUserToDeleteRows = false;
            this.datos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datos.Location = new System.Drawing.Point(0, 99);
            this.datos.Name = "datos";
            this.datos.ReadOnly = true;
            this.datos.RowHeadersWidth = 51;
            this.datos.Size = new System.Drawing.Size(1168, 469);
            this.datos.TabIndex = 229;
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
            this.btnAAgregar.ButtonText = "Registrar camilla";
            this.btnAAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnAAgregar.IdleBorderThickness = 1;
            this.btnAAgregar.IdleCornerRadius = 20;
            this.btnAAgregar.IdleFillColor = System.Drawing.Color.White;
            this.btnAAgregar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnAAgregar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnAAgregar.Location = new System.Drawing.Point(881, 45);
            this.btnAAgregar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAAgregar.Name = "btnAAgregar";
            this.btnAAgregar.Size = new System.Drawing.Size(143, 41);
            this.btnAAgregar.TabIndex = 230;
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
            this.bunifuThinButton21.ButtonText = "Eliminar";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(14, 576);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(109, 41);
            this.bunifuThinButton21.TabIndex = 242;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 16);
            this.label14.TabIndex = 244;
            this.label14.Text = "ID camilla:";
            // 
            // lugar
            // 
            this.lugar.BorderColorFocused = System.Drawing.Color.Blue;
            this.lugar.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.lugar.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.lugar.BorderThickness = 1;
            this.lugar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lugar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lugar.ForeColor = System.Drawing.Color.Gray;
            this.lugar.isPassword = false;
            this.lugar.Location = new System.Drawing.Point(6, 56);
            this.lugar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lugar.Name = "lugar";
            this.lugar.Size = new System.Drawing.Size(209, 33);
            this.lugar.TabIndex = 243;
            this.lugar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // buscar
            // 
            this.buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscar.Image = global::Talent.Properties.Resources.buscar;
            this.buscar.Location = new System.Drawing.Point(220, 62);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(23, 22);
            this.buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buscar.TabIndex = 245;
            this.buscar.TabStop = false;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // Lugares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1035, 630);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lugar);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.btnAAgregar);
            this.Controls.Add(this.datos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lugares";
            this.Text = "Lugares";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAAgregar;
        private System.Windows.Forms.DataGridView datos;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.Label label14;
        private Bunifu.Framework.UI.BunifuMetroTextbox lugar;
        private System.Windows.Forms.PictureBox buscar;
    }
}