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
    public partial class Empleados : Form
    {

        DataTable dt = new DataTable();

        public Empleados()
        {
            InitializeComponent();
            dt.Columns.Add("ID");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Apellido Paterno");
            dt.Columns.Add("Apellido Materno");
            dt.Columns.Add("Tipo Empleado");
            datos.DataSource = dt;
            Cargar();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {

        }

        private void btnAAgregar_Click(object sender, EventArgs e)
        {
            Registr abrirEmpleados = new Registr(dt.Rows.Count);
            abrirEmpleados.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLIniciarSesion_Click(object sender, EventArgs e)
        {
            InformacionEmpleado abrirInfoEmpleados = new InformacionEmpleado(datos.CurrentRow.Cells[0].Value.ToString());
            abrirInfoEmpleados.Show();

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            RegistrarRH abrirRegistrarRH = new RegistrarRH();
            abrirRegistrarRH.Show();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            if(empleado.Text.Equals(""))
            {
                Cargar();
            }
            else if(!empleado.Text.Equals("1"))
            {
                Buscar();
            }
            else
            {
                MessageBox.Show("Informacion no disponible");
            }
        }

        public void Cargar()
        {
            dt.Rows.Clear();
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("select id_empleados,nombre,ape_pat,ape_mat,tipo_empleado from empleados where id_empleados > 1", conexionBD.conectar);

                MySqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    DataRow row = dt.NewRow();

                    row["ID"] = registros["id_empleados"].ToString();
                    row["Nombre"] = registros["nombre"].ToString();
                    row["Apellido Paterno"] = registros["ape_pat"].ToString();
                    row["Apellido Materno"] = registros["ape_mat"].ToString();
                    row["Tipo Empleado"] = registros["tipo_empleado"].ToString();
                    dt.Rows.Add(row);
                }

                conexionBD.cerrar();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al solicitar informacion");
            }
        }

        public void Buscar()
        {
            dt.Rows.Clear();
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("select id_empleados,nombre,ape_pat,ape_mat,tipo_empleado from empleados where id_empleados = " + empleado.text, conexionBD.conectar);

                MySqlDataReader registros = comando.ExecuteReader();

                //"Total: " + registros["total"].ToString() +

                while (registros.Read())
                {
                    DataRow row = dt.NewRow();

                    row["ID"] = registros["id_empleados"].ToString();
                    row["Nombre"] = registros["nombre"].ToString();
                    row["Apellido Paterno"] = registros["ape_pat"].ToString();
                    row["Apellido Materno"] = registros["ape_mat"].ToString();
                    row["Tipo Empleado"] = registros["tipo_empleado"].ToString();
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

