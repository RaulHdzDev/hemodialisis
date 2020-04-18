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
    public partial class ActualizarArticulo : Form
    {
        string id;

        public ActualizarArticulo(string id)
        {
            InitializeComponent();
            this.id = id;
            Cargar();
        }

        //codigo para poder arrastrar la ventana por la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //codigo para poder arrastrar la ventana por la pantalla

        private void ActualizarArticulo_Load(object sender, EventArgs e)
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

        public void Cargar()
        {
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("select nom_articulo,cant_articulo from articulos where id_articulos = " + id, conexionBD.conectar);

                MySqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    nombre.Text = registros["nom_articulo"].ToString();
                    cantidad.Text = registros["cant_articulo"].ToString();
                }

                conexionBD.cerrar();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al solicitar informacion");
            }
        }

        public void Actualizar()
        {
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("update articulos set cant_articulo = " + cantidad.Text + ", nom_articulo = '" + nombre.Text + "' where id_articulos = " + id, conexionBD.conectar);

                comando.ExecuteNonQuery();

                conexionBD.cerrar();

                MessageBox.Show("Exito");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al solicitar el registro. Por favor intentelo mas tarde " + e);
            }
        }

        public void Eliminar()
        {
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("delete from articulos where id_articulos = " + id, conexionBD.conectar);

                comando.ExecuteNonQuery();

                conexionBD.cerrar();

                MessageBox.Show("Eliminacion exitosa");

                this.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al solicitar el delete. Por favor intentelo mas tarde");
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnAgregarActualizar_Click(object sender, EventArgs e)
        {
            if (!nombre.Text.Equals("") && !cantidad.Text.Equals(""))
            {
                Actualizar();
            }
            else
            {
                MessageBox.Show("Por favor ingrese los datos necesarios");
            }
        }
    }
}
