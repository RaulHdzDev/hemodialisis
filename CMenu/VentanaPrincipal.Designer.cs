namespace Talent
{
    partial class VentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PanelGeneral = new System.Windows.Forms.Panel();
            this.panelHora = new System.Windows.Forms.Panel();
            this.fecha = new System.Windows.Forms.Label();
            this.hora = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.btnAntecedentes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAlmacen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLugares = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEmpleados = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPacientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCitas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInicio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PanelGeneral.SuspendLayout();
            this.panelHora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelIzquierdo.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 34);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Talent.Properties.Resources.logo_bloop_void;
            this.pictureBox6.Location = new System.Drawing.Point(11, 6);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(26, 23);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(166)))), ((int)(((byte)(220)))));
            this.label10.Location = new System.Drawing.Point(37, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 23);
            this.label10.TabIndex = 4;
            this.label10.Text = "Bienvenido";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::Talent.Properties.Resources.cerrarApp;
            this.pictureBox5.Location = new System.Drawing.Point(1131, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::Talent.Properties.Resources.maximizarAPP;
            this.pictureBox4.Location = new System.Drawing.Point(1100, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Talent.Properties.Resources.mini;
            this.pictureBox2.Location = new System.Drawing.Point(1069, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // PanelGeneral
            // 
            this.PanelGeneral.Controls.Add(this.panelHora);
            this.PanelGeneral.Controls.Add(this.label1);
            this.PanelGeneral.Controls.Add(this.pictureBox3);
            this.PanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelGeneral.Location = new System.Drawing.Point(180, 34);
            this.PanelGeneral.Name = "PanelGeneral";
            this.PanelGeneral.Size = new System.Drawing.Size(988, 596);
            this.PanelGeneral.TabIndex = 10;
            // 
            // panelHora
            // 
            this.panelHora.BackColor = System.Drawing.Color.White;
            this.panelHora.Controls.Add(this.fecha);
            this.panelHora.Controls.Add(this.hora);
            this.panelHora.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHora.Location = new System.Drawing.Point(0, 552);
            this.panelHora.Name = "panelHora";
            this.panelHora.Size = new System.Drawing.Size(988, 44);
            this.panelHora.TabIndex = 8;
            this.panelHora.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHora_Paint);
            // 
            // fecha
            // 
            this.fecha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.fecha.AutoSize = true;
            this.fecha.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.ForeColor = System.Drawing.Color.Black;
            this.fecha.Location = new System.Drawing.Point(831, 24);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(0, 16);
            this.fecha.TabIndex = 1;
            // 
            // hora
            // 
            this.hora.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.hora.AutoSize = true;
            this.hora.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora.ForeColor = System.Drawing.Color.Black;
            this.hora.Location = new System.Drawing.Point(894, 0);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(0, 25);
            this.hora.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(133, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(705, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "Take care of your blood";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::Talent.Properties.Resources.fondoSistem;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(988, 596);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.AutoScroll = true;
            this.panelIzquierdo.BackColor = System.Drawing.Color.White;
            this.panelIzquierdo.Controls.Add(this.btnAntecedentes);
            this.panelIzquierdo.Controls.Add(this.btnAlmacen);
            this.panelIzquierdo.Controls.Add(this.btnLugares);
            this.panelIzquierdo.Controls.Add(this.btnEmpleados);
            this.panelIzquierdo.Controls.Add(this.btnPacientes);
            this.panelIzquierdo.Controls.Add(this.btnCitas);
            this.panelIzquierdo.Controls.Add(this.btnInicio);
            this.panelIzquierdo.Controls.Add(this.bunifuFlatButton1);
            this.panelIzquierdo.Controls.Add(this.panel2);
            this.panelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzquierdo.Location = new System.Drawing.Point(0, 34);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(180, 596);
            this.panelIzquierdo.TabIndex = 9;
            // 
            // btnAntecedentes
            // 
            this.btnAntecedentes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnAntecedentes.BackColor = System.Drawing.Color.Transparent;
            this.btnAntecedentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAntecedentes.BorderRadius = 0;
            this.btnAntecedentes.ButtonText = "Antecedentes";
            this.btnAntecedentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAntecedentes.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnAntecedentes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAntecedentes.Font = new System.Drawing.Font("Ancient", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAntecedentes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAntecedentes.Iconimage = global::Talent.Properties.Resources.expediente1;
            this.btnAntecedentes.Iconimage_right = null;
            this.btnAntecedentes.Iconimage_right_Selected = null;
            this.btnAntecedentes.Iconimage_Selected = null;
            this.btnAntecedentes.IconMarginLeft = 0;
            this.btnAntecedentes.IconMarginRight = 0;
            this.btnAntecedentes.IconRightVisible = true;
            this.btnAntecedentes.IconRightZoom = 100D;
            this.btnAntecedentes.IconVisible = true;
            this.btnAntecedentes.IconZoom = 90D;
            this.btnAntecedentes.IsTab = false;
            this.btnAntecedentes.Location = new System.Drawing.Point(0, 469);
            this.btnAntecedentes.Margin = new System.Windows.Forms.Padding(4);
            this.btnAntecedentes.Name = "btnAntecedentes";
            this.btnAntecedentes.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAntecedentes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnAntecedentes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAntecedentes.selected = false;
            this.btnAntecedentes.Size = new System.Drawing.Size(180, 55);
            this.btnAntecedentes.TabIndex = 35;
            this.btnAntecedentes.Text = "Antecedentes";
            this.btnAntecedentes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAntecedentes.Textcolor = System.Drawing.Color.Black;
            this.btnAntecedentes.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAntecedentes.Click += new System.EventHandler(this.btnAntecedentes_Click);
            // 
            // btnAlmacen
            // 
            this.btnAlmacen.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnAlmacen.BackColor = System.Drawing.Color.Transparent;
            this.btnAlmacen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlmacen.BorderRadius = 0;
            this.btnAlmacen.ButtonText = "Almacen";
            this.btnAlmacen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlmacen.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnAlmacen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlmacen.Font = new System.Drawing.Font("Ancient", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlmacen.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAlmacen.Iconimage = global::Talent.Properties.Resources.almacen1;
            this.btnAlmacen.Iconimage_right = null;
            this.btnAlmacen.Iconimage_right_Selected = null;
            this.btnAlmacen.Iconimage_Selected = null;
            this.btnAlmacen.IconMarginLeft = 0;
            this.btnAlmacen.IconMarginRight = 0;
            this.btnAlmacen.IconRightVisible = true;
            this.btnAlmacen.IconRightZoom = 100D;
            this.btnAlmacen.IconVisible = true;
            this.btnAlmacen.IconZoom = 90D;
            this.btnAlmacen.IsTab = false;
            this.btnAlmacen.Location = new System.Drawing.Point(0, 414);
            this.btnAlmacen.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlmacen.Name = "btnAlmacen";
            this.btnAlmacen.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAlmacen.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnAlmacen.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAlmacen.selected = false;
            this.btnAlmacen.Size = new System.Drawing.Size(180, 55);
            this.btnAlmacen.TabIndex = 33;
            this.btnAlmacen.Text = "Almacen";
            this.btnAlmacen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlmacen.Textcolor = System.Drawing.Color.Black;
            this.btnAlmacen.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlmacen.Click += new System.EventHandler(this.btnAlmacen_Click);
            // 
            // btnLugares
            // 
            this.btnLugares.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnLugares.BackColor = System.Drawing.Color.Transparent;
            this.btnLugares.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLugares.BorderRadius = 0;
            this.btnLugares.ButtonText = "Lugares";
            this.btnLugares.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLugares.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnLugares.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLugares.Font = new System.Drawing.Font("Ancient", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLugares.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLugares.Iconimage = global::Talent.Properties.Resources.CAMILLA_BLANCA;
            this.btnLugares.Iconimage_right = null;
            this.btnLugares.Iconimage_right_Selected = null;
            this.btnLugares.Iconimage_Selected = null;
            this.btnLugares.IconMarginLeft = 0;
            this.btnLugares.IconMarginRight = 0;
            this.btnLugares.IconRightVisible = true;
            this.btnLugares.IconRightZoom = 100D;
            this.btnLugares.IconVisible = true;
            this.btnLugares.IconZoom = 90D;
            this.btnLugares.IsTab = false;
            this.btnLugares.Location = new System.Drawing.Point(0, 359);
            this.btnLugares.Margin = new System.Windows.Forms.Padding(4);
            this.btnLugares.Name = "btnLugares";
            this.btnLugares.Normalcolor = System.Drawing.Color.Transparent;
            this.btnLugares.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnLugares.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLugares.selected = false;
            this.btnLugares.Size = new System.Drawing.Size(180, 55);
            this.btnLugares.TabIndex = 31;
            this.btnLugares.Text = "Lugares";
            this.btnLugares.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLugares.Textcolor = System.Drawing.Color.Black;
            this.btnLugares.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLugares.Click += new System.EventHandler(this.btnLugares_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnEmpleados.BackColor = System.Drawing.Color.Transparent;
            this.btnEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmpleados.BorderRadius = 0;
            this.btnEmpleados.ButtonText = "Empleados";
            this.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleados.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleados.Font = new System.Drawing.Font("Ancient", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEmpleados.Iconimage = global::Talent.Properties.Resources.empleados;
            this.btnEmpleados.Iconimage_right = null;
            this.btnEmpleados.Iconimage_right_Selected = null;
            this.btnEmpleados.Iconimage_Selected = null;
            this.btnEmpleados.IconMarginLeft = 0;
            this.btnEmpleados.IconMarginRight = 0;
            this.btnEmpleados.IconRightVisible = true;
            this.btnEmpleados.IconRightZoom = 100D;
            this.btnEmpleados.IconVisible = true;
            this.btnEmpleados.IconZoom = 90D;
            this.btnEmpleados.IsTab = false;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 304);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEmpleados.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnEmpleados.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEmpleados.selected = false;
            this.btnEmpleados.Size = new System.Drawing.Size(180, 55);
            this.btnEmpleados.TabIndex = 29;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Textcolor = System.Drawing.Color.Black;
            this.btnEmpleados.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnPacientes
            // 
            this.btnPacientes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnPacientes.BackColor = System.Drawing.Color.Transparent;
            this.btnPacientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPacientes.BorderRadius = 0;
            this.btnPacientes.ButtonText = "Pacientes";
            this.btnPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPacientes.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPacientes.Font = new System.Drawing.Font("Ancient", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacientes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPacientes.Iconimage = global::Talent.Properties.Resources.pacientes1;
            this.btnPacientes.Iconimage_right = null;
            this.btnPacientes.Iconimage_right_Selected = null;
            this.btnPacientes.Iconimage_Selected = null;
            this.btnPacientes.IconMarginLeft = 0;
            this.btnPacientes.IconMarginRight = 0;
            this.btnPacientes.IconRightVisible = true;
            this.btnPacientes.IconRightZoom = 100D;
            this.btnPacientes.IconVisible = true;
            this.btnPacientes.IconZoom = 90D;
            this.btnPacientes.IsTab = false;
            this.btnPacientes.Location = new System.Drawing.Point(0, 249);
            this.btnPacientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPacientes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnPacientes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPacientes.selected = false;
            this.btnPacientes.Size = new System.Drawing.Size(180, 55);
            this.btnPacientes.TabIndex = 27;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacientes.Textcolor = System.Drawing.Color.Black;
            this.btnPacientes.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // btnCitas
            // 
            this.btnCitas.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnCitas.BackColor = System.Drawing.Color.Transparent;
            this.btnCitas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCitas.BorderRadius = 0;
            this.btnCitas.ButtonText = "Citas";
            this.btnCitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCitas.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCitas.Font = new System.Drawing.Font("Ancient", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCitas.Iconimage = global::Talent.Properties.Resources.citas1;
            this.btnCitas.Iconimage_right = null;
            this.btnCitas.Iconimage_right_Selected = null;
            this.btnCitas.Iconimage_Selected = null;
            this.btnCitas.IconMarginLeft = 0;
            this.btnCitas.IconMarginRight = 0;
            this.btnCitas.IconRightVisible = true;
            this.btnCitas.IconRightZoom = 100D;
            this.btnCitas.IconVisible = true;
            this.btnCitas.IconZoom = 90D;
            this.btnCitas.IsTab = false;
            this.btnCitas.Location = new System.Drawing.Point(0, 194);
            this.btnCitas.Margin = new System.Windows.Forms.Padding(4);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCitas.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnCitas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCitas.selected = false;
            this.btnCitas.Size = new System.Drawing.Size(180, 55);
            this.btnCitas.TabIndex = 25;
            this.btnCitas.Text = "Citas";
            this.btnCitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCitas.Textcolor = System.Drawing.Color.Black;
            this.btnCitas.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitas.Click += new System.EventHandler(this.btnCitas_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInicio.BorderRadius = 0;
            this.btnInicio.ButtonText = "Inicio";
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.Font = new System.Drawing.Font("Ancient", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInicio.Iconimage = global::Talent.Properties.Resources.inicio;
            this.btnInicio.Iconimage_right = null;
            this.btnInicio.Iconimage_right_Selected = null;
            this.btnInicio.Iconimage_Selected = null;
            this.btnInicio.IconMarginLeft = 0;
            this.btnInicio.IconMarginRight = 0;
            this.btnInicio.IconRightVisible = true;
            this.btnInicio.IconRightZoom = 100D;
            this.btnInicio.IconVisible = true;
            this.btnInicio.IconZoom = 90D;
            this.btnInicio.IsTab = false;
            this.btnInicio.Location = new System.Drawing.Point(0, 139);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(4);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Normalcolor = System.Drawing.Color.Transparent;
            this.btnInicio.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.btnInicio.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInicio.selected = false;
            this.btnInicio.Size = new System.Drawing.Size(180, 55);
            this.btnInicio.TabIndex = 23;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Textcolor = System.Drawing.Color.Black;
            this.btnInicio.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(25)))), ((int)(((byte)(110)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Cerrar Sesión";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(166)))), ((int)(((byte)(220)))));
            this.bunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Ancient", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::Talent.Properties.Resources.cerrarsesion1;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 100D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 556);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(166)))), ((int)(((byte)(220)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(180, 40);
            this.bunifuFlatButton1.TabIndex = 12;
            this.bunifuFlatButton1.Text = "Cerrar Sesión";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 139);
            this.panel2.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Talent.Properties.Resources.poster2_14_91331;
            this.pictureBox1.Location = new System.Drawing.Point(18, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1168, 630);
            this.Controls.Add(this.PanelGeneral);
            this.Controls.Add(this.panelIzquierdo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaPrincipal";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PanelGeneral.ResumeLayout(false);
            this.PanelGeneral.PerformLayout();
            this.panelHora.ResumeLayout(false);
            this.panelHora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelIzquierdo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelGeneral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panelIzquierdo;
        private Bunifu.Framework.UI.BunifuFlatButton btnAntecedentes;
        private Bunifu.Framework.UI.BunifuFlatButton btnAlmacen;
        private Bunifu.Framework.UI.BunifuFlatButton btnLugares;
        private Bunifu.Framework.UI.BunifuFlatButton btnEmpleados;
        private Bunifu.Framework.UI.BunifuFlatButton btnPacientes;
        private Bunifu.Framework.UI.BunifuFlatButton btnCitas;
        private Bunifu.Framework.UI.BunifuFlatButton btnInicio;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelHora;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.Timer HoraFecha;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label10;
    }
}