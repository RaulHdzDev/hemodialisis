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
    public partial class AgregarArticulo : Form
    {
        public AgregarArticulo()
        {
            InitializeComponent();
            Cargar();
        }


        //codigo para poder arrastrar la ventana por la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //codigo para poder arrastrar la ventana por la pantalla


        private void btnCancelarActualizar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AgregarArticulo_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAgregarActualizar_Click(object sender, EventArgs e)
        {
            int numero;
            bool comprobar = Int32.TryParse(cantidad.Text, out numero);

            if (!cantidad.Text.Equals("") && comprobar == true)
            {
                Agregar(Buscar());
            }
            else
            {
                MessageBox.Show("Por favor ingresa los datos necesarios");
            }
        }

        public int Buscar()
        {
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("select cant_articulo from articulos where nom_articulo = '" + nombre.SelectedItem.ToString() + "'", conexionBD.conectar);

                MySqlDataReader registros = comando.ExecuteReader();

                registros.Read();

                int cantidad = Int32.Parse(registros["cant_articulo"].ToString());

                conexionBD.cerrar();

                return cantidad;

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al buscar: " + e);
                return 0;
            }
        }

        public void Agregar(int cantidad)
        {
            try
            {
                cantidad = cantidad + Int32.Parse(this.cantidad.Text);
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("update articulos set cant_articulo = " + cantidad + " where nom_articulo = '" + nombre.SelectedItem.ToString() + "'", conexionBD.conectar);

                comando.ExecuteNonQuery();

                conexionBD.cerrar();

                MessageBox.Show("Exito");

                Limpiar();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al solicitar el registro. Por favor intentelo mas tarde");
            }
        }

        public void Cargar()
        {
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("select nom_articulo from articulos", conexionBD.conectar);

                MySqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    nombre.Items.Add(registros["nom_articulo"]);
                }

                conexionBD.cerrar();

                nombre.SelectedIndex = 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al solicitar informacion");
            }
        }

        public void Limpiar()
        {
            cantidad.Text = "";
        }
    }
}
