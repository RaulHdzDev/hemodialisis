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

namespace Talent
{
    public partial class citas : Form
    {
        String idCita = "";
        DataTable dt = new DataTable();

        public citas()
        {
            InitializeComponent();
            dt.Columns.Add("idCita");
            dt.Columns.Add("Paciente");
            dt.Columns.Add("Empleado");
            dt.Columns.Add("Camilla");
            dt.Columns.Add("Fecha");
            dt.Columns.Add("Hora");
            dataGV.DataSource = dt;
            Cargar();
        }

        public void Cargar()
        {
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("SELECT citas.id_citas, citas.id_camilla, citas.fecha, citas.hora, empleados.nombre as nomEmp, empleados.ape_pat as patEmp, empleados.ape_mat as matEmp, " +
                    "pacientes.nombre as nomPac, pacientes.ape_pat as patPac, pacientes.ape_mat as matPac FROM((citas INNER JOIN pacientes ON citas.id_pacientes = pacientes.id_pacientes) " +
                    "INNER JOIN empleados ON citas.id_empleados = empleados.id_empleados);", conexionBD.conectar);

                MySqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    DataRow row = dt.NewRow();

                    row["idCita"] = registros["id_citas"].ToString();
                    row["Paciente"] = registros["nomPac"].ToString() + " " + registros["patPac"].ToString() + " " + registros["matPac"].ToString();
                    row["Empleado"] = registros["nomEmp"].ToString() + " " + registros["patEmp"].ToString() + " " + registros["matEmp"].ToString();
                    row["Camilla"] = registros["id_camilla"].ToString();
                    row["Fecha"] = registros["fecha"].ToString();
                    row["Hora"] = registros["hora"].ToString();

                    dt.Rows.Add(row);
                }

                conexionBD.cerrar();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al solicitar informacion " + e);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuMetroTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
         
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
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

        private void RegistrarAlumnos_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAAgregar_Click(object sender, EventArgs e)
        {
            RegistrarCita abrirRegistrarCitas = new RegistrarCita();
            abrirRegistrarCitas.Show();
        }

        private void btnLIniciarSesion_Click(object sender, EventArgs e)
        {
            if(idCita == "")
            {
                MessageBox.Show("Por favor, seleccione alguna cita dando un clic.");
            } else
            {
                ActualizarCita abrirActualizarCitas = new ActualizarCita(idCita);
                abrirActualizarCitas.Show();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idCita = dataGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                idCita = dataGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {

            }

        }

       

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            if (idCita == "")
            {
                MessageBox.Show("Por favor, seleccione alguna cita dando un clic.");
            }
            else
            {
                MostrarAntigenos abrirMostrarAntigenos = new MostrarAntigenos(idCita);
                abrirMostrarAntigenos.Show();
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (idCita == "")
            {
                MessageBox.Show("Por favor, seleccione alguna cita dando un clic.");
            }
            else
            {
                InformacionCita abrirMostrarInfoCita = new InformacionCita(idCita);
                abrirMostrarInfoCita.Show();
            }
        }

        private void txt_user_OnTextChange(object sender, EventArgs e)
        {
            Buscar();
        }

        public void Buscar()
        {
            dt.Rows.Clear();
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("SELECT citas.id_citas, citas.id_camilla, citas.fecha, citas.hora, empleados.nombre, empleados.ape_pat, empleados.ape_mat, " +
                    "pacientes.nombre, pacientes.ape_pat, pacientes.ape_mat FROM((citas INNER JOIN pacientes ON citas.id_pacientes = pacientes.id_pacientes) " +
                    "INNER JOIN empleados ON citas.id_empleados = empleados.id_empleados) " +
                    "WHERE pacientes.nombre LIKE %" + txt_user + "% OR pacientes.ape_pat LIKE %" + txt_user + "% OR pacientes.ape_mat LIKE %" + txt_user + "%;", conexionBD.conectar);

                MySqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    DataRow row = dt.NewRow();

                    row["idCita"] = registros["citas.id_citas"].ToString();
                    row["Paciente"] = registros["pacientes.nombre"].ToString() + " " + registros["pacientes.ape_pat"].ToString() + " " + registros["pacientes.ape_mat"].ToString();
                    row["Empleado"] = registros["empleados.nombre"].ToString() + " " + registros["empleados.ape_pat"].ToString() + " " + registros["empleados.ape_mat"].ToString();
                    row["Camilla"] = registros["citas.id_camilla"].ToString();
                    row["Fecha"] = registros["citas.fecha"].ToString();
                    row["Hora"] = registros["citas.hora"].ToString();
                    dt.Rows.Add(row);
                }

                conexionBD.cerrar();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al solicitar informacion");
            }
        }
    }
}
