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
    public partial class MenuInicioDoctor : Form
    {

        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DateTime dateTime = DateTime.Today;
        List<string> arregloID1 = new List<string>();
        List<string> arregloID2 = new List<string>();
        List<string> arregloNombre = new List<string>();
        string[] arregloP1;


        public MenuInicioDoctor()
        {
            InitializeComponent();

            dt.Columns.Add("ID");
            dt.Columns.Add("Paciente");
            dt.Columns.Add("Encargado");
            dt.Columns.Add("Hora");
            citasDeHoy.DataSource = dt;

            dt2.Columns.Add("ID");
            dt2.Columns.Add("Nombre");
            dt2.Columns.Add("Apellido Paterno");
            dt2.Columns.Add("Apellido Materno");
            enfermerasLibres.DataSource = dt2;

            Puestos();
            Articulos();
            Camillas();
            Citas();
            CitasHoy();
            EmpleadosLibres();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void EmpleadosLibres()
        {
            EmpleadosOcupados();
            EmpleadosEnfermeras();

            for (int i = 0; i < arregloID1.Count; i++)
            {
                for (int j = 0; j < arregloID2.Count; j++)
                {
                    if (arregloID1[i].Equals(arregloID2[j]))
                    {
                        arregloID2.RemoveAt(j);
                        arregloNombre.RemoveAt(j);
                        j--;
                    }
                }
            }

            for (int i = 0; i < arregloID2.Count; i++)
            {
                DataRow row2 = dt2.NewRow();

                row2["ID"] = arregloID2[i];

                arregloP1 = arregloNombre[i].Split(',');

                row2["Nombre"] = arregloP1[0];
                row2["Apellido Paterno"] = arregloP1[1];
                row2["Apellido Materno"] = arregloP1[2];
                dt2.Rows.Add(row2);
            }
        }

        public void EmpleadosOcupados()
        {
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("select id_empleados,fecha from citas", conexionBD.conectar);
                
                MySqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    if(registros["fecha"].ToString().Substring(0,10).Equals(dateTime.ToString("dd/MM/yyyy")))
                    {
                        arregloID1.Add(registros["id_empleados"].ToString());
                    }
                    
                }

                conexionBD.cerrar();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al solicitar informacion");
            }
        }

        public void EmpleadosEnfermeras()
        {
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("select id_empleados,nombre,ape_pat,ape_mat from empleados where tipo_empleado = 'Enfermera'", conexionBD.conectar);

                MySqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    arregloID2.Add(registros["id_empleados"].ToString());
                    arregloNombre.Add(registros["nombre"].ToString() + "," + registros["ape_pat"].ToString() + "," + registros["ape_mat"].ToString());
                }

                conexionBD.cerrar();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al solicitar informacion");
            }
        }

        public void CitasHoy()
        {

            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("select citas.id_citas as id_citas, pacientes.nombre as nombrePaciente, pacientes.ape_pat as apePaciente, empleados.nombre as nombreEmpleado, empleados.ape_pat as apeEmpleado, citas.hora as hora, citas.fecha as fecha from citas INNER JOIN pacientes ON citas.id_pacientes = pacientes.id_pacientes INNER JOIN empleados ON citas.id_empleados = empleados.id_empleados", conexionBD.conectar);

                MySqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    if (registros["fecha"].ToString().Substring(0, 10).Equals(dateTime.ToString("dd/MM/yyyy")))
                    {
                        DataRow row = dt.NewRow();

                        row["ID"] = registros["id_citas"].ToString();
                        row["Paciente"] = registros["nombrePaciente"].ToString() + " " + registros["apePaciente"].ToString();
                        row["Encargado"] = registros["nombreEmpleado"].ToString() + " " + registros["apeEmpleado"].ToString();
                        row["Hora"] = registros["hora"].ToString();
                        dt.Rows.Add(row);
                    }
                }

                conexionBD.cerrar();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al solicitar informacion " + e);
            }
        }

        public void Citas()
        {
            int cantidad1 = 0, cantidad2 = 0;
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("select count(id_citas) as cantidad from citas", conexionBD.conectar);

                MySqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    cantidad1 = Int32.Parse(registros["cantidad"].ToString());
                }

                registros.Close();

                MySqlCommand comando2 = new MySqlCommand("select count(id_citas_accesos_antigenos) as cantidad from citas_accesos_antigenos", conexionBD.conectar);

                MySqlDataReader registros2 = comando2.ExecuteReader();

                while (registros2.Read())
                {
                    cantidad2 = Int32.Parse(registros2["cantidad"].ToString());
                }

                citasPendientes.Text = (cantidad1 - cantidad2).ToString();

                conexionBD.cerrar();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al solicitar informacion " + e);
            }
        }

        public void Camillas()
        {
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("select count(id_camillas) as cantidad from camillas", conexionBD.conectar);

                MySqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    lugares.Text = registros["cantidad"].ToString();
                }

                conexionBD.cerrar();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al solicitar informacion");
            }
        }

        public void Articulos()
        {
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("select count(id_articulos) as cantidad from articulos", conexionBD.conectar);

                MySqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    articulosRegistrados.Text = registros["cantidad"].ToString();
                }

                conexionBD.cerrar();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al solicitar informacion");
            }
        }

        public void Puestos()
        {
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("select count(id_empleados) as cantidad, tipo_empleado from empleados group by tipo_empleado", conexionBD.conectar);

                MySqlDataReader registros = comando.ExecuteReader();

                string tipo;
                /*
                Enfermera
                Pasante
                Medico
                Secretaria
                Intendente
                Seguridad
                Recursos humanos
                */

                while (registros.Read())
                {
                    tipo = registros["tipo_empleado"].ToString();

                    switch (tipo)
                    {
                        case "Enfermera":
                            enfermeria.Text = registros["cantidad"].ToString();
                            break;

                        case "Pasante":
                            pasantes.Text = registros["cantidad"].ToString();
                            break;

                        case "Medico":
                            medicos.Text = registros["cantidad"].ToString();
                            break;

                        case "Secretaria":
                            secretarias.Text = registros["cantidad"].ToString();
                            break;

                        case "Intendente":
                            intendente.Text = registros["cantidad"].ToString();
                            break;

                        case "Seguridad":
                            seguridad.Text = registros["cantidad"].ToString();
                            break;

                        default:
                            break;
                    }
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
