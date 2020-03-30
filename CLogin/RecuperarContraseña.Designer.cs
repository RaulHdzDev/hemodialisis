namespace Talent
{
    partial class RecuperarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperarContraseña));
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_user = new Bunifu.Framework.UI.BunifuTextbox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escriba su  correo para recuperar la contraseña";
            // 
            // btnEditar
            // 
            this.btnEditar.ActiveBorderThickness = 1;
            this.btnEditar.ActiveCornerRadius = 20;
            this.btnEditar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnEditar.ActiveForecolor = System.Drawing.Color.White;
            this.btnEditar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.ButtonText = "Recuperar";
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnEditar.IdleBorderThickness = 1;
            this.btnEditar.IdleCornerRadius = 20;
            this.btnEditar.IdleFillColor = System.Drawing.Color.White;
            this.btnEditar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnEditar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnEditar.Location = new System.Drawing.Point(178, 156);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(113, 51);
            this.btnEditar.TabIndex = 55;
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.Color.White;
            this.txt_user.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_user.BackgroundImage")));
            this.txt_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.txt_user.Icon = ((System.Drawing.Image)(resources.GetObject("txt_user.Icon")));
            this.txt_user.Location = new System.Drawing.Point(61, 98);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(346, 39);
            this.txt_user.TabIndex = 232;
            this.txt_user.text = "";
            // 
            // RecuperarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(473, 269);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecuperarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperar contraseña";
            this.Load += new System.EventHandler(this.Inscribir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEditar;
        private Bunifu.Framework.UI.BunifuTextbox txt_user;
    }
}