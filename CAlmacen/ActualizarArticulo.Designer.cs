﻿namespace Talent
{
    partial class ActualizarArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizarArticulo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cantidad = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.nombre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnCancelarActualizar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAgregarActualizar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(166)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 203);
            this.panel1.TabIndex = 226;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(166)))), ((int)(((byte)(220)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(314, 40);
            this.label4.TabIndex = 236;
            this.label4.Text = "Actualizar articulo";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(656, 43);
            this.panel2.TabIndex = 235;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::Talent.Properties.Resources.CerrarBlanco;
            this.pictureBox5.Location = new System.Drawing.Point(615, 6);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(33, 31);
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
            this.pictureBox2.Location = new System.Drawing.Point(573, 6);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 282);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 19);
            this.label2.TabIndex = 225;
            this.label2.Text = "Cantidad de articulo:";
            // 
            // cantidad
            // 
            this.cantidad.BorderColorFocused = System.Drawing.Color.Blue;
            this.cantidad.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.cantidad.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.cantidad.BorderThickness = 1;
            this.cantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cantidad.ForeColor = System.Drawing.Color.Gray;
            this.cantidad.isPassword = false;
            this.cantidad.Location = new System.Drawing.Point(109, 295);
            this.cantidad.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(412, 41);
            this.cantidad.TabIndex = 224;
            this.cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 223);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 19);
            this.label1.TabIndex = 223;
            this.label1.Text = "Nombre del articulo:";
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
            this.nombre.Location = new System.Drawing.Point(109, 236);
            this.nombre.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(412, 41);
            this.nombre.TabIndex = 222;
            this.nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnCancelarActualizar
            // 
            this.btnCancelarActualizar.ActiveBorderThickness = 1;
            this.btnCancelarActualizar.ActiveCornerRadius = 20;
            this.btnCancelarActualizar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnCancelarActualizar.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancelarActualizar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnCancelarActualizar.BackColor = System.Drawing.Color.White;
            this.btnCancelarActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelarActualizar.BackgroundImage")));
            this.btnCancelarActualizar.ButtonText = "Cancelar";
            this.btnCancelarActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarActualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnCancelarActualizar.IdleBorderThickness = 1;
            this.btnCancelarActualizar.IdleCornerRadius = 20;
            this.btnCancelarActualizar.IdleFillColor = System.Drawing.Color.White;
            this.btnCancelarActualizar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnCancelarActualizar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnCancelarActualizar.Location = new System.Drawing.Point(485, 378);
            this.btnCancelarActualizar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnCancelarActualizar.Name = "btnCancelarActualizar";
            this.btnCancelarActualizar.Size = new System.Drawing.Size(151, 50);
            this.btnCancelarActualizar.TabIndex = 221;
            this.btnCancelarActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgregarActualizar
            // 
            this.btnAgregarActualizar.ActiveBorderThickness = 1;
            this.btnAgregarActualizar.ActiveCornerRadius = 20;
            this.btnAgregarActualizar.ActiveFillColor = System.Drawing.Color.Green;
            this.btnAgregarActualizar.ActiveForecolor = System.Drawing.Color.White;
            this.btnAgregarActualizar.ActiveLineColor = System.Drawing.Color.Green;
            this.btnAgregarActualizar.BackColor = System.Drawing.Color.White;
            this.btnAgregarActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarActualizar.BackgroundImage")));
            this.btnAgregarActualizar.ButtonText = "Guardar";
            this.btnAgregarActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarActualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarActualizar.ForeColor = System.Drawing.Color.Green;
            this.btnAgregarActualizar.IdleBorderThickness = 1;
            this.btnAgregarActualizar.IdleCornerRadius = 20;
            this.btnAgregarActualizar.IdleFillColor = System.Drawing.Color.White;
            this.btnAgregarActualizar.IdleForecolor = System.Drawing.Color.Green;
            this.btnAgregarActualizar.IdleLineColor = System.Drawing.Color.Green;
            this.btnAgregarActualizar.Location = new System.Drawing.Point(321, 378);
            this.btnAgregarActualizar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnAgregarActualizar.Name = "btnAgregarActualizar";
            this.btnAgregarActualizar.Size = new System.Drawing.Size(151, 50);
            this.btnAgregarActualizar.TabIndex = 220;
            this.btnAgregarActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarActualizar.Click += new System.EventHandler(this.btnAgregarActualizar_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
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
            this.bunifuThinButton21.Location = new System.Drawing.Point(21, 378);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(113, 50);
            this.bunifuThinButton21.TabIndex = 227;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ActualizarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(656, 446);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.btnCancelarActualizar);
            this.Controls.Add(this.btnAgregarActualizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ActualizarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Articulo";
            this.Load += new System.EventHandler(this.ActualizarArticulo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox cantidad;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox nombre;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancelarActualizar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAgregarActualizar;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}