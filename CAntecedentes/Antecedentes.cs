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
    public partial class Antecedentes : Form
    {

        DataTable dt = new DataTable();

        public Antecedentes()
        {
            InitializeComponent();
            dt.Columns.Add("Id_Empleado");
            dt.Columns.Add("Id_Articulo");
            dt.Columns.Add("Cantidad");
            datos.DataSource = dt;
            Cargar();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAAgregar_Click(object sender, EventArgs e)
        {
           /* RegistrarAntecedentes abrirRegistrarAntecedentes = new RegistrarAntecedentes();
            abrirRegistrarAntecedentes.Show();
            */

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            /*
            ActualizarAntecedente abrirActualizar= new ActualizarAntecedente();
            abrirActualizar.Show();
            */
        }

        private void btnLIniciarSesion_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Cargar()
        {
            dt.Rows.Clear();
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("select id_empleados,id_articulos,cantidad from bitacora", conexionBD.conectar);

                MySqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    DataRow row = dt.NewRow();

                    row["Id_Empleado"] = registros["id_empleados"].ToString();
                    row["Id_Articulo"] = registros["id_articulos"].ToString();
                    row["Cantidad"] = registros["cantidad"].ToString();

                    dt.Rows.Add(row);
                }

                conexionBD.cerrar();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al solicitar informacion");
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (id.Text.Equals(""))
            {
                Cargar();
            }
            else
            {
                Buscar();
            }
        }

        public void Buscar()
        {
            dt.Rows.Clear();
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("select id_empleados,id_articulos,cantidad from bitacora where id_empleados = " + id.text, conexionBD.conectar);

                MySqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    DataRow row = dt.NewRow();

                    row["Id_Empleado"] = registros["id_empleados"].ToString();
                    row["Id_Articulo"] = registros["id_articulos"].ToString();
                    row["Cantidad"] = registros["cantidad"].ToString();

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
