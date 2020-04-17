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
    public partial class RegistrarCita : Form
    {
        String Camillas = "";
        String Empleado = "";
        String idEmpleado = "";
        String Paciente = "";
        String idPaciente = "";
        String fecha = "";
        String hora = "";

        public RegistrarCita()
        {
            InitializeComponent();
            Cargar();
        }

        public void nombresEmple()
        {
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("select nombre, ape_pat, ape_mat from empleados", conexionBD.conectar);

                MySqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    String nombreCompleto = registros["nombre"].ToString() + " " + registros["ape_pat"].ToString() + " " + registros["ape_mat"].ToString();
                    cbEncaRCita.Items.Add(nombreCompleto);
                }

                conexionBD.cerrar();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al solicitar informacion");
            }
        }

        public void nombresPacie()
        {
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("select nombre, ape_pat, ape_mat from pacientes", conexionBD.conectar);

                MySqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    String nombreCompleto = registros["nombre"].ToString() + " " + registros["ape_pat"].ToString() + " " + registros["ape_mat"].ToString();
                    cbPacRCita.Items.Add(nombreCompleto);
                    //agregar a combobox
                }

                conexionBD.cerrar();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al solicitar informacion");
            }
        }

        public void Cargar()
        {
            nombresEmple();
            nombresPacie();
            camillas();
        }

        public void camillas()
        {
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("select id_camillas from camillas", conexionBD.conectar);

                MySqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    //agregar a combobox
                    String camillas = registros["id_camillas"].ToString();
                    cbCamiRCita.Items.Add(camillas);
                }

                conexionBD.cerrar();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al solicitar informacion");
            }
        }

        //codigo para poder arrastrar la ventana por la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //codigo para poder arrastrar la ventana por la pantalla

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarAlumno_Load(object sender, EventArgs e)
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

        private void btnAgregarActualizar_Click(object sender, EventArgs e)
        {

        }

        
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
        
           
        }

        private void panelVerArticulos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
     
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCancelarActualizar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAgregarActualizar_Click_1(object sender, EventArgs e)
        {
            RegistrarCitas();
        }

        public void datosEmpleado()
        {
            String[] listaEmpleado = Empleado.Split(' ');
            String nombre= "";
            String ape_pat="";
            String ape_mat="";
            if (listaEmpleado.Length == 3)
            {
                nombre = listaEmpleado[0];
                ape_pat = listaEmpleado[1];
                ape_mat = listaEmpleado[2];
            }else if (listaEmpleado.Length == 4)
            {
                nombre = listaEmpleado[0] + " " + listaEmpleado[1];
                ape_pat = listaEmpleado[2];
                ape_mat = listaEmpleado[3];
            }
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("select id_empleados from empleados " +
                    "where nombre = '" + nombre + "' and ape_pat = '"+ape_pat+"' and ape_mat = '"+ape_mat+"';", conexionBD.conectar);

                MySqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    idEmpleado = registros["id_empleados"].ToString();
                }

                conexionBD.cerrar();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al solicitar informacion");
            }

        }

        public void datosPaciente()
        {
            String[] listaPaciente = Paciente.Split(' ');
            String nombre = "";
            String ape_pat = "";
            String ape_mat = "";
            if (listaPaciente.Length == 3)
            {
                nombre = listaPaciente[0];
                ape_pat = listaPaciente[1];
                ape_mat = listaPaciente[2];
            }
            else if (listaPaciente.Length == 4)
            {
                nombre = listaPaciente[0] + " " + listaPaciente[1];
                ape_pat = listaPaciente[2];
                ape_mat = listaPaciente[3];
            }
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("select id_pacientes from pacientes " +
                    "where nombre = '" + nombre + "' and ape_pat = '" + ape_pat + "' and ape_mat = '" + ape_mat + "';", conexionBD.conectar);

                MySqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    idPaciente = registros["id_pacientes"].ToString();
                }

                conexionBD.cerrar();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al solicitar informacion");
            }

        }

        private void RegistrarCitas()
        {
            Camillas = cbCamiRCita.SelectedItem.ToString();
            Paciente = cbPacRCita.SelectedItem.ToString();
            Empleado = cbEncaRCita.SelectedItem.ToString();
            fecha = dpFechaRCita.Value.ToString();
            String fechaDia = fecha.Substring(0,2);
            String fechaAño1 = fecha.Substring(6);
            String fechaAñoF = fechaAño1.Substring(0,4);
            String fechaMes = fecha.Substring(2, 4);
            String fechaFinal = fechaAñoF + fechaMes + fechaDia;
            hora = cbHoraRCita.SelectedItem.ToString() + ":00";
            datosPaciente();
            datosEmpleado();
            if (Paciente == "" || Camillas == "" || Empleado == "" || fecha == "" || hora == "")
            {
                MessageBox.Show("Llene todos los campos por favor.");
            }
            else
            {
                try
                {
                    conexionBD.abrir();

                    MySqlCommand comando = new MySqlCommand("insert into citas (id_pacientes, id_empleados, id_camilla, hora, fecha) " +
                        "values('" + idPaciente + "', '" + idEmpleado + "', '" + Camillas + "', '" + hora +"', '" + fechaFinal + "');", conexionBD.conectar);

                    comando.ExecuteNonQuery();

                    conexionBD.cerrar();

                    MessageBox.Show("Registro exitoso");

                }
                catch (Exception e)
                {
                    MessageBox.Show("Error al solicitar el registro. Por favor intentelo mas tarde" + e.Message);
                }
            }
        }
    }
}
