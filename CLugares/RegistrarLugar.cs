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
    public partial class RegistrarLugar : Form
    {
        public RegistrarLugar()
        {
            InitializeComponent();
        }

        //codigo para poder arrastrar la ventana por la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //codigo para poder arrastrar la ventana por la pantalla


        private void RegistrarLugar_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelarActualizar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAgregarActualizar_Click(object sender, EventArgs e)
        {
            if (!cantidad.Text.Equals(""))
            {
                for (int i = 0; i < Int32.Parse(cantidad.Text); i++)
                {
                    Registrar();
                }

                MessageBox.Show("Registro completado");
                cantidad.Text = "";
            }
            else
            {
                MessageBox.Show("Por favor llene todos los campos");
            }
        }

        public void Registrar()
        {
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("insert into camillas(estado_lugar) values('Libre')", conexionBD.conectar);

                comando.ExecuteNonQuery();

                conexionBD.cerrar();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al eliminar" + e);
            }
        }
    }
}
