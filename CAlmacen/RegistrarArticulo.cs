using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
using Talent.datos;

namespace Talent
{
    public partial class ActualizarAlmacen : Form
    {
        public ActualizarAlmacen()
        {
            InitializeComponent();
        }


        //codigo para poder arrastrar la ventana por la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //codigo para poder arrastrar la ventana por la pantalla


        private void TxtANombreArticulo_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtACantidad_OnValueChanged(object sender, EventArgs e)
        {

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

        private void btnCancelarActualizar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAgregarActualizar_Click(object sender, EventArgs e)
        {
            int numero;
            bool comprobar = Int32.TryParse(cantidad.Text, out numero);

            if (!nombre.Text.Equals("") && !cantidad.Text.Equals("") && comprobar == true)
            {
                Registrar();
            }
            else
            {
                MessageBox.Show("Por favor rellene todos los campos");
            }
        }

        public void Registrar()
        {
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("insert into articulos(nom_articulo,cant_articulo) values('" + nombre.Text + "'," + cantidad.Text + ")", conexionBD.conectar);

                comando.ExecuteNonQuery();

                conexionBD.cerrar();

                MessageBox.Show("Registro exitoso");

                Limpiar();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al solicitar el registro. Por favor intentelo mas tarde");
            }

        }

        public void Limpiar()
        {
            nombre.Text = "";
            cantidad.Text = "";
        }
    }
}
