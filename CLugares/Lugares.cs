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
    public partial class Lugares : Form
    {
        DataTable dt = new DataTable();
        public Lugares()
        {
            InitializeComponent();
            dt.Columns.Add("ID");
            dt.Columns.Add("Estado");
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
            RegistrarLugar abrirRegistrarLugar = new RegistrarLugar();
            abrirRegistrarLugar.Show();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
          
        }

        public void Cargar()
        {
            dt.Rows.Clear();
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("select id_camillas, estado_lugar from camillas", conexionBD.conectar);

                MySqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    DataRow row = dt.NewRow();

                    row["ID"] = registros["id_camillas"].ToString();
                    row["Estado"] = registros["estado_lugar"].ToString();
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

                MySqlCommand comando = new MySqlCommand("select id_camillas, estado_lugar from camillas where id_camillas = " + lugar.Text, conexionBD.conectar);

                MySqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    DataRow row = dt.NewRow();

                    row["ID"] = registros["id_camillas"].ToString();
                    row["Estado"] = registros["estado_lugar"].ToString();
                    dt.Rows.Add(row);
                }

                conexionBD.cerrar();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al solicitar informacion");
            }
        }

        public void Eliminar()
        {
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("delete from camillas where id_camillas = " + datos.CurrentRow.Cells[0].Value.ToString(), conexionBD.conectar);

                comando.ExecuteNonQuery();

                conexionBD.cerrar();

                MessageBox.Show("Exito");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al eliminar" + e);
            }
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            if (lugar.Text.Equals(""))
            {
                Cargar();
            }
            else
            {
                Buscar();
            }
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            Eliminar();
        }
    }
}
