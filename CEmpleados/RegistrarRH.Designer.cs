namespace Talent
{
    partial class RegistrarRH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarRH));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.apellidoM = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.correo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.apellidoP = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.password = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLIniciarSesion = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(166)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 40);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(5, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 23);
            this.label10.TabIndex = 5;
            this.label10.Text = "Recursos Humanos";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::Talent.Properties.Resources.CerrarBlanco;
            this.pictureBox5.Location = new System.Drawing.Point(337, 6);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Talent.Properties.Resources.MinimizarBlanco;
            this.pictureBox2.Location = new System.Drawing.Point(306, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 105;
            this.label2.Text = "Nombre:";
            // 
            // nombre
            // 
            this.nombre.BorderColorFocused = System.Drawing.Color.Blue;
            this.nombre.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.nombre.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.nombre.BorderThickness = 1;
            this.nombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.nombre.ForeColor = System.Drawing.Color.Gray;
            this.nombre.isPassword = false;
            this.nombre.Location = new System.Drawing.Point(59, 89);
            this.nombre.Margin = new System.Windows.Forms.Padding(4);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(244, 33);
            this.nombre.TabIndex = 1;
            this.nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 107;
            this.label1.Text = "Apellido materno:";
            // 
            // apellidoM
            // 
            this.apellidoM.BorderColorFocused = System.Drawing.Color.Blue;
            this.apellidoM.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.apellidoM.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.apellidoM.BorderThickness = 1;
            this.apellidoM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.apellidoM.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.apellidoM.ForeColor = System.Drawing.Color.Gray;
            this.apellidoM.isPassword = false;
            this.apellidoM.Location = new System.Drawing.Point(59, 206);
            this.apellidoM.Margin = new System.Windows.Forms.Padding(4);
            this.apellidoM.Name = "apellidoM";
            this.apellidoM.Size = new System.Drawing.Size(244, 33);
            this.apellidoM.TabIndex = 3;
            this.apellidoM.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 109;
            this.label3.Text = "Correo:";
            // 
            // correo
            // 
            this.correo.BorderColorFocused = System.Drawing.Color.Blue;
            this.correo.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.correo.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.correo.BorderThickness = 1;
            this.correo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.correo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.correo.ForeColor = System.Drawing.Color.Gray;
            this.correo.isPassword = false;
            this.correo.Location = new System.Drawing.Point(59, 265);
            this.correo.Margin = new System.Windows.Forms.Padding(4);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(244, 33);
            this.correo.TabIndex = 4;
            this.correo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 111;
            this.label4.Text = "Apellido paterno:";
            // 
            // apellidoP
            // 
            this.apellidoP.BorderColorFocused = System.Drawing.Color.Blue;
            this.apellidoP.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.apellidoP.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.apellidoP.BorderThickness = 1;
            this.apellidoP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.apellidoP.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.apellidoP.ForeColor = System.Drawing.Color.Gray;
            this.apellidoP.isPassword = false;
            this.apellidoP.Location = new System.Drawing.Point(59, 149);
            this.apellidoP.Margin = new System.Windows.Forms.Padding(4);
            this.apellidoP.Name = "apellidoP";
            this.apellidoP.Size = new System.Drawing.Size(244, 33);
            this.apellidoP.TabIndex = 2;
            this.apellidoP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 113;
            this.label5.Text = "Contraseña";
            // 
            // password
            // 
            this.password.BorderColorFocused = System.Drawing.Color.Blue;
            this.password.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.password.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.password.BorderThickness = 1;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.password.ForeColor = System.Drawing.Color.Gray;
            this.password.isPassword = false;
            this.password.Location = new System.Drawing.Point(59, 328);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(244, 33);
            this.password.TabIndex = 5;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.bunifuThinButton21);
            this.panel2.Controls.Add(this.btnLIniciarSesion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 404);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 53);
            this.panel2.TabIndex = 114;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.bunifuThinButton21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Cancelar";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(249, 6);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(109, 41);
            this.bunifuThinButton21.TabIndex = 23;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // btnLIniciarSesion
            // 
            this.btnLIniciarSesion.ActiveBorderThickness = 1;
            this.btnLIniciarSesion.ActiveCornerRadius = 20;
            this.btnLIniciarSesion.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLIniciarSesion.ActiveForecolor = System.Drawing.Color.White;
            this.btnLIniciarSesion.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLIniciarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLIniciarSesion.BackColor = System.Drawing.Color.White;
            this.btnLIniciarSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLIniciarSesion.BackgroundImage")));
            this.btnLIniciarSesion.ButtonText = "Guardar";
            this.btnLIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLIniciarSesion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLIniciarSesion.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLIniciarSesion.IdleBorderThickness = 1;
            this.btnLIniciarSesion.IdleCornerRadius = 20;
            this.btnLIniciarSesion.IdleFillColor = System.Drawing.Color.White;
            this.btnLIniciarSesion.IdleForecolor = System.Drawing.Color.DeepSkyBlue;
            this.btnLIniciarSesion.IdleLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLIniciarSesion.Location = new System.Drawing.Point(135, 6);
            this.btnLIniciarSesion.Margin = new System.Windows.Forms.Padding(5);
            this.btnLIniciarSesion.Name = "btnLIniciarSesion";
            this.btnLIniciarSesion.Size = new System.Drawing.Size(104, 41);
            this.btnLIniciarSesion.TabIndex = 22;
            this.btnLIniciarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLIniciarSesion.Click += new System.EventHandler(this.btnLIniciarSesion_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // RegistrarRH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(369, 457);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.apellidoP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.apellidoM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrarRH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RegistrarRH_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegistrarRH_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox nombre;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox apellidoM;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox correo;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox apellidoP;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox password;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLIniciarSesion;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}