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
    public partial class ActualizarCita : Form
    {
        String idCita = "";
        String Empleado = "";
        String idEmpleado = "";
        String Paciente = "";
        String idPaciente="0";

        public ActualizarCita(String id)
        {
            InitializeComponent();
            idCita = id;
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
                    //agregar a combobox
                    String nombreCompleto = registros["nombre"].ToString() + " " + registros["ape_pat"].ToString() + " " + registros["ape_mat"].ToString();
                    cbEmpActCita.Items.Add(nombreCompleto);
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
                    //agregar a combobox
                    String nombreCompleto = registros["nombre"].ToString() + " " + registros["ape_pat"].ToString() + " " + registros["ape_mat"].ToString();
                    cbPaciAntCita.Items.Add(nombreCompleto);
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
                    cbCamillaActCita.Items.Add(camillas);
                }

                conexionBD.cerrar();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al solicitar informacion");
            }
        }

        public void datosEmpleado()
        {
            String[] listaEmpleado = Empleado.Split(' ');
            String nombre = "";
            String ape_pat = "";
            String ape_mat = "";
            if (listaEmpleado.Length == 3)
            {
                nombre = listaEmpleado[0];
                ape_pat = listaEmpleado[1];
                ape_mat = listaEmpleado[2];
            }
            else if (listaEmpleado.Length == 4)
            {
                nombre = listaEmpleado[0] + " " + listaEmpleado[1];
                ape_pat = listaEmpleado[2];
                ape_mat = listaEmpleado[3];
            }
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("select id_empleados from empleados " +
                    "where nombre = '" + nombre + "' and ape_pat = '" + ape_pat + "' and ape_mat = '" + ape_mat + "';", conexionBD.conectar);

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

        //codigo para poder arrastrar la ventana por la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //codigo para poder arrastrar la ventana por la pantalla


        private void ActualizarCita_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelarActualizar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAgregarActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
            this.Hide();
        }

        public void Actualizar()
        {
            try
            {
                String Camillas = cbCamillaActCita.SelectedItem.ToString();
                Paciente = cbPaciAntCita.SelectedItem.ToString();
                Empleado = cbEmpActCita.SelectedItem.ToString();
                String fecha = dpFechaActCita.Value.ToString();
                String fechaDia = fecha.Substring(0, 2);
                String fechaAño1 = fecha.Substring(6);
                String fechaAñoF = fechaAño1.Substring(0, 4);
                String fechaMes = fecha.Substring(2, 4);
                String fechaFinal = fechaAñoF + fechaMes + fechaDia;
                String hora = cbHoraActCita.SelectedItem.ToString() + ":00";
                datosEmpleado();
                datosPaciente();
                conexionBD.abrir();
                MySqlCommand comando = new MySqlCommand("update citas set id_pacientes = '" + idPaciente + "', id_empleados = '" + idEmpleado +
                    "', id_camilla = '" + Camillas + "', fecha = '" + fechaFinal + "', hora = '" + hora +
                    "' where id_citas = '" + idCita + "';", conexionBD.conectar);

                comando.ExecuteNonQuery();

                conexionBD.cerrar();

                MessageBox.Show("Update exitoso");

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al solicitar el update. Por favor intentelo mas tarde " + e);
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            eliminar();
            this.Hide();
        }

        public void eliminar()
        {
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("delete from citas where id_citas = " + idCita, conexionBD.conectar);

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
    }
}
