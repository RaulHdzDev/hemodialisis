﻿namespace Talent
{
    partial class AgregarArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarArticulo));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuMetroTextbox2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnCancelarActualizar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAgregarActualizar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(166)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 165);
            this.panel1.TabIndex = 242;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(465, 35);
            this.panel3.TabIndex = 234;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Talent.Properties.Resources.CerrarBlanco;
            this.pictureBox1.Location = new System.Drawing.Point(434, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Talent.Properties.Resources.MinimizarBlanco;
            this.pictureBox3.Location = new System.Drawing.Point(403, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(166)))), ((int)(((byte)(220)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 32);
            this.label4.TabIndex = 232;
            this.label4.Text = "Agregar articulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 241;
            this.label2.Text = "Cantidad:";
            // 
            // bunifuMetroTextbox2
            // 
            this.bunifuMetroTextbox2.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.bunifuMetroTextbox2.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox2.BorderThickness = 1;
            this.bunifuMetroTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox2.ForeColor = System.Drawing.Color.Gray;
            this.bunifuMetroTextbox2.isPassword = false;
            this.bunifuMetroTextbox2.Location = new System.Drawing.Point(45, 243);
            this.bunifuMetroTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox2.Name = "bunifuMetroTextbox2";
            this.bunifuMetroTextbox2.Size = new System.Drawing.Size(370, 33);
            this.bunifuMetroTextbox2.TabIndex = 240;
            this.bunifuMetroTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btnCancelarActualizar.Location = new System.Drawing.Point(302, 299);
            this.btnCancelarActualizar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelarActualizar.Name = "btnCancelarActualizar";
            this.btnCancelarActualizar.Size = new System.Drawing.Size(113, 41);
            this.btnCancelarActualizar.TabIndex = 237;
            this.btnCancelarActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelarActualizar.Click += new System.EventHandler(this.btnCancelarActualizar_Click);
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
            this.btnAgregarActualizar.ButtonText = "Agregar";
            this.btnAgregarActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarActualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarActualizar.ForeColor = System.Drawing.Color.Green;
            this.btnAgregarActualizar.IdleBorderThickness = 1;
            this.btnAgregarActualizar.IdleCornerRadius = 20;
            this.btnAgregarActualizar.IdleFillColor = System.Drawing.Color.White;
            this.btnAgregarActualizar.IdleForecolor = System.Drawing.Color.Green;
            this.btnAgregarActualizar.IdleLineColor = System.Drawing.Color.Green;
            this.btnAgregarActualizar.Location = new System.Drawing.Point(180, 299);
            this.btnAgregarActualizar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregarActualizar.Name = "btnAgregarActualizar";
            this.btnAgregarActualizar.Size = new System.Drawing.Size(113, 41);
            this.btnAgregarActualizar.TabIndex = 236;
            this.btnAgregarActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 320;
            this.label1.Text = "Nombre del articulo:";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.White;
            this.comboBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.Black;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(45, 196);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(370, 24);
            this.comboBox2.TabIndex = 319;
            // 
            // AgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(465, 347);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuMetroTextbox2);
            this.Controls.Add(this.btnCancelarActualizar);
            this.Controls.Add(this.btnAgregarActualizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarArticulo";
            this.Load += new System.EventHandler(this.AgregarArticulo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancelarActualizar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAgregarActualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}