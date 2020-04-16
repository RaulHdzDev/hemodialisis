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
using Talent.datos;
using MySql.Data.MySqlClient;

namespace Talent
{
    public partial class RegistrarRH : Form
    {
        public RegistrarRH()
        {
            InitializeComponent();
        }


        //codigo para poder arrastrar la ventana por la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //codigo para poder arrastrar la ventana por la pantalla


        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void RegistrarRH_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLIniciarSesion_Click(object sender, EventArgs e)
        {
            Registrar();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Registrar()
        {
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("insert into empleados(nombre, ape_pat, ape_mat,correo,tipo_empleado) values('" + nombre.Text + "','" + apellidoP.Text + "','" + apellidoM.Text + "', '" + correo.Text + "','Recursos humanos')", conexionBD.conectar);

                comando.ExecuteNonQuery();

                MySqlCommand comando2 = new MySqlCommand("select id_empleados from empleados where (correo = '"+correo.Text+"') AND (tipo_empleado = 'Recursos humanos')", conexionBD.conectar);

                MySqlDataReader registros = comando2.ExecuteReader();

                registros.Read();

                MySqlCommand comando3 = new MySqlCommand("insert into usuarios(id_empleados,nombre,ape_pat,ape_mat,tipo_empleado,correo,contra_usuario) values("+registros["id_empleados"].ToString()+",'"+nombre.Text+"','"+apellidoP.Text+"','"+apellidoM.Text+"','Recursos humanos','"+correo.Text+"','"+password.Text+"')",conexionBD.conectar);

                registros.Close();

                comando3.ExecuteNonQuery();

                conexionBD.cerrar();

                MessageBox.Show("Registro exitoso");

                Limpiar();

                this.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al solicitar el registro. Por favor intentelo mas tarde");
            }
        }

        public void Limpiar()
        {
            nombre.Text = "";
            apellidoP.Text = "";
            apellidoM.Text = "";
            correo.Text = "";
            password.Text = "";
        }

        private void RegistrarRH_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
