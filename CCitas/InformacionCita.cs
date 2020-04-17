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
    public partial class InformacionCita : Form
    {
        String idCita = "";
        String nomPaciente = "";
        String nomEmpleado = "";
        String fecha = "";
        String hora = "";
        String camilla = "";

        public InformacionCita(String id)
        {
            InitializeComponent();
            idCita = id;
            Cargar();
        }

        //codigo para poder arrastrar la ventana por la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //codigo para poder arrastrar la ventana por la pantalla

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Cargar()
        {
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("SELECT citas.id_camilla, citas.fecha, citas.hora, empleados.nombre as nomEmp, empleados.ape_pat as patEmp, empleados.ape_mat as matEmp, " +
                    "pacientes.nombre as nomPac, pacientes.ape_pat as patPac, pacientes.ape_mat as matPac FROM((citas INNER JOIN pacientes ON citas.id_pacientes = pacientes.id_pacientes) " +
                    "INNER JOIN empleados ON citas.id_empleados = empleados.id_empleados) WHERE id_citas = " + idCita + ";", conexionBD.conectar);

                MySqlDataReader registros = comando.ExecuteReader();

                //"Total: " + registros["total"].ToString() +

                while (registros.Read())
                {
                    nomEmpleado = registros["nomEmp"].ToString() + " " + registros["patEmp"].ToString() + " " + registros["matEmp"].ToString();
                    nomPaciente = registros["nomPac"].ToString() + " " + registros["patPac"].ToString() + " " + registros["matPac"].ToString();
                    fecha = registros["fecha"].ToString();
                    hora = registros["hora"].ToString();
                    camilla = registros["id_camilla"].ToString();
                }
                nomEmpInfoCita.Text = nomEmpleado;
                nomPaInfoCita.Text = nomPaciente;
                fechaInfoCita.Text = fecha;
                horaInfoCita.Text = hora;
                camillaInfoCita.Text = camilla;
                conexionBD.cerrar();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al solicitar informacion " + e);
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            ActualizarCita abrirActualizarCita = new ActualizarCita(idCita);
            abrirActualizarCita.Show();
            this.Hide();

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

        private void InformacionCita_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLIniciarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
