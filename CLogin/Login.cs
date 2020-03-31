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
using MySql.Data.MySqlClient;

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


        //iniciar sesion
        private void btnLIniciarSesion_Click(object sender, EventArgs e)
        {
            string correo = txtLUsuario.Text;
            string contraseña = txtLContraseña.Text;

            MySqlDataReader msqldr = null;

            try
            {
                using (MySqlCommand comando = new MySqlCommand("Select nombre, correo, contra_usuario from usuarios where " +
                    "correo = '" + correo.Trim() + "' AND contra_usuario = '" + contraseña.Trim() + "'", conexionBD.conectar))
                {
                    msqldr = comando.ExecuteReader();

                    if (msqldr.Read())
                    {
                        VentanaPrincipal AbrirPrincipal = new VentanaPrincipal();
                        AbrirPrincipal.Show();
                        this.Hide();
                    }
                    else if (correo == "" || contraseña == "")
                    {
                        MessageBox.Show("Ingrese un Usuario o una Contraseña");
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Contraseña incorrecta");
                    }
                    msqldr.Close();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            
        }



        //registrar
        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            RegistrarAdmin abrirRegistrarAdmin = new RegistrarAdmin();
            abrirRegistrarAdmin.Show();
            this.Hide();
        }




    }
}
