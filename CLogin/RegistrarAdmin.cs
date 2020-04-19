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
using MySql.Data.MySqlClient;
using Talent.datos;

namespace Talent
{
    public partial class RegistrarAdmin : Form
    {
        public RegistrarAdmin()
        {
            InitializeComponent();
        }



        //codigo para poder arrastrar la ventana por la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //codigo para poder arrastrar la ventana por la pantalla




        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegistrarAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnLIniciarSesion_Click(object sender, EventArgs e)
        {
            Form regresarlogin = new Login();
            this.Hide();
            regresarlogin.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login abrirLogin = new Login();
            abrirLogin.Show();
        }

        private void btnLIniciarSesion_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login abrirLogin = new Login();
            abrirLogin.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                conexionBD.abrir();

            string nombre =          txtLUsuario.Text;
            string apeliidoPaterno = txtApellidoP.Text;
            string apellidoMaterno = txtApellidoM.Text;
            string correo =          txtCorreo.Text;
            string contraseña =      txtContraseña.Text;
            string numEmpleado =     txtNum.Text;
            int idempleado =         Int32.Parse(numEmpleado);
            string tipoEmpleado =    comboBox1.Text;

            MySqlDataReader mysqldr = null;
            
                using (MySqlCommand comando = new MySqlCommand("Insert Into usuarios (id_empleados, nombre, " +
                    "ape_pat, ape_mat, tipo_empleado, correo, contra_usuario) Values (" + idempleado +
                    ",'" + nombre + "','" + apeliidoPaterno + "','" + apellidoMaterno + "','" + tipoEmpleado + "','"
                    + correo + "','" + contraseña + "')", conexionBD.conectar))
                {

                        if (nombre == "")
                        {
                            MessageBox.Show("Ingrese un nombre");
                        }
                        else if (apeliidoPaterno == "") 
                        {
                            MessageBox.Show("Ingrese un apellido Paterno");
                        }
                        else if (apellidoMaterno == "")
                        {
                            MessageBox.Show("Ingrese un apellido Materno");
                        }
                        else if (tipoEmpleado == "")
                        {
                        MessageBox.Show("Ingrese el tipo de empleado");
                        }
                        else if (correo == "")
                        {
                            MessageBox.Show("Ingrese un correo electronico");
                        }
                        else if (contraseña == "")
                        {
                            MessageBox.Show("Ingrese una contraseña");
                        }
                        else if (numEmpleado == "")
                        {
                            MessageBox.Show("Ingrese un número de empleado");
                        }
                        else
                        {
                            mysqldr = comando.ExecuteReader();

                        if (mysqldr.RecordsAffected == 1)
                        {
                            MessageBox.Show("Se a registrado con éxito");

                            Login AbrirPrincipal = new Login();
                            AbrirPrincipal.Show();
                            this.Hide();
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

         }
    }
}
