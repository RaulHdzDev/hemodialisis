﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Talent
{
    public partial class VentanaPrincipal : Form
    {

        public VentanaPrincipal()
        {
            InitializeComponent();
        }
    


        //Mostrar y ocultar botones
        public void BotonesAMostrar()
        {
        }





        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            BotonesAMostrar();
        }




        //codigo para poder arrastrar la ventana por la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //codigo para poder arrastrar la ventana por la pantalla

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //mover ventana
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private Form formActivo = null;
        private void abrirform(Form formHijo)
        {
            if (formActivo != null)
                formActivo.Close();
            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            PanelGeneral.Controls.Add(formHijo);
            PanelGeneral.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }



        public void mostrarPaneles(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocultarPaneles();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        public void ocultarPaneles()
        {
           
        }



        //Hora y fecha inicio
        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToString("hh:mm:ss");
            fecha.Text = DateTime.Now.ToLongDateString();
        }




        //Cerrar Aplicacion
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Maximizar
        private void pictureBox4_Click(object sender, EventArgs e)
        {           
            if (this.WindowState == FormWindowState.Normal) {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        //Minimizar
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }






        //botones Ventana Principal
        private void btnInicio_Click(object sender, EventArgs e)
        {
            abrirform(new MenuInicioDoctor());
            ocultarPaneles();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            abrirform(new citas());
            ocultarPaneles();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            abrirform(new Paciente());
            ocultarPaneles();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            abrirform(new Empleados());
            ocultarPaneles();
        }

        private void btnLugares_Click(object sender, EventArgs e)
        {
            abrirform(new Lugares());
            ocultarPaneles();
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            abrirform(new aux());
            ocultarPaneles();
        }

        private void btnAntecedentes_Click(object sender, EventArgs e)
        {
            abrirform(new Antecedentes());
            ocultarPaneles();
        }

        private void panelHora_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
