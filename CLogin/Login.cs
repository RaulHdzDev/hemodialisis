using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using Talent.datos;

/*
Lo puse en comentario para poder correr con los cambios
using Talent.Dominio;
*/



namespace Talent
{
    public partial class Login : Form
    {
        conexionBD obj = new conexionBD();
        
        public Login()
        {
            InitializeComponent();
            conexionBD.abrir();
        }

        //codigo para poder arrastrar la ventana por la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //codigo para poder arrastrar la ventana por la pantalla


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

      


        //lo puse en comentarios para poder correr con los cambios
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {



            /*
             
-------------------------------------------------------------
Estos son los tipos de usuarios que tendra la aplicacion
si tienen sugerencias o quieren cambiar algo esta bien
(A continuacion indico los botones que se van a mostrar dependiendo a el tipo de usuario)


            ***el boton solo se pondra en visible para cada tipo de usuario****



+Administrador master:
  -Inicio(El inicio que le corresponde a RH)
  -Citas
  -Pacientes
  -Empleados(Se habilitara un boton para acceder a la ventana para registrar RH)
  -Lugares
  -Almacen
  -Antecedentes


+Recursos Humanos:
  -Inicio(El inicio que le corresponde a RH)
  -Empleados
  -Almacen


+Secretaria:
  -Inicio
  -Citas
  -Pacientes
  -Lugares
  -Antecedentes


+Doctor:
  -Inicio
  -Citas
  -Pacientes
  -Lugares
  -Antecedentes


+Intendente
+Seguridad

------------------------------------------------------------------------
             */






            /*MetodosLogin loginB = new MetodosLogin();
            int respuesta = loginB.Login(txtLUsuario.Text, txtLContraseña.Text);
            switch (respuesta)
            {
                case 1:
                    MessageBox.Show("Login exitoso!");
                    VentanaPrincipal AbrirPrincipal = new VentanaPrincipal();
                    AbrirPrincipal.Show();
                    this.Hide();
                    break;
                case 2:
                    MessageBox.Show("Credenciales incorrectas");
                    break;
                case 3:
                    MessageBox.Show("Hay un error");
                    break;
            }
            */






         
            //Descartar cuando quiten comentarios
            VentanaPrincipal AbrirPrincipal = new VentanaPrincipal();
            AbrirPrincipal.Show();
            this.Hide();

        }







        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecuperarContraseña AbrirRecuperarContraseña = new RecuperarContraseña();
            AbrirRecuperarContraseña.Show();      
        }

        private void TxtLUsuario_Enter(object sender, EventArgs e)
        {
            if(txtLUsuario.Text == "Usuario o Correo")
            {
                txtLUsuario.Text = "";
            }
        }

        private void TxtLUsuario_Leave(object sender, EventArgs e)
        {
            if (txtLUsuario.Text == "")
            {
                txtLUsuario.Text = "Usuario o Correo";
            }
        }

        private void TxtLContraseña_Enter(object sender, EventArgs e)
        {
            if (txtLContraseña.Text == "Contraseña")
            {
                txtLContraseña.Text = "";
            }
        }

        private void TxtLContraseña_Leave(object sender, EventArgs e)
        {
            if (txtLContraseña.Text == "")
            {
                txtLContraseña.Text = "Contraseña";
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            RegistrarAdmin abrirRegistrarAdmin = new RegistrarAdmin();
            abrirRegistrarAdmin.Show();
            this.Hide();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
