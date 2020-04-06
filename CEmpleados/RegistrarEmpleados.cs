using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Talent.datos;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace Talent
{
    public partial class Registr : Form
    {
        public Registr()
        {
            InitializeComponent();
        }

        //codigo para poder arrastrar la ventana por la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //codigo para poder arrastrar la ventana por la pantalla


        private void RegistrarEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Registrar();
        }

        private void btnAAgregar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Registrar()
        {
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("insert into empleados(nombre, ape_pat, ape_mat, edad, calle, num_ext, num_int, colonia, tipo_empleado, correo, cedula_prof, num_tel) values('" + nombre.Text + "','" + apellidoP.Text + "','" + apellidoM.Text + "'," + edad.Text + "," + calle.Text + "," + numeroE.Text + "," + numeroI.Text + "," + colonia.Text + ",'" + tipoE.SelectedItem.ToString() + "', '" + correo.Text + "', " + cedulaP.Text + ", "+telefono.Text+")", conexionBD.conectar);

                comando.ExecuteNonQuery();

                conexionBD.cerrar();

                MessageBox.Show("Registro exitoso");

                Limpiar();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al solicitar el registro. Por favor intentelo mas tarde" + e.Message);
            }

        }

        public void Limpiar()
        {
            nombre.Text = "";
            apellidoP.Text = "";
            apellidoM.Text = "";
            edad.Text = "";
            calle.Text = "";
            numeroE.Text = "";
            numeroI.Text = "";
            colonia.Text = "";
            correo.Text = "";
            cedulaP.Text = "";
            telefono.Text = "";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
