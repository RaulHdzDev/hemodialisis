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
    public partial class aux : Form
    {

        DataTable dt = new DataTable();

        public aux()
        {
            InitializeComponent();
            dt.Columns.Add("ID");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Cantidad");
            datos.DataSource = dt;
            Cargar();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAAgregar_Click(object sender, EventArgs e)
        {
            ActualizarAlmacen AbrirActualiarAlmacen = new ActualizarAlmacen();
            AbrirActualiarAlmacen.Show();
           
        }

        private void Almacen_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            ActualizarArticulo AbrirActualiar = new ActualizarArticulo(datos.CurrentRow.Cells[0].Value.ToString());
            AbrirActualiar.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            AgregarArticulo AbrirAgregarArticulo = new AgregarArticulo();
            AbrirAgregarArticulo.Show();
        }

        public void Cargar()
        {
            dt.Rows.Clear();
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("select id_articulos,nom_articulo,cant_articulo from articulos", conexionBD.conectar);

                MySqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    DataRow row = dt.NewRow();

                    row["ID"] = registros["id_articulos"].ToString();
                    row["Nombre"] = registros["nom_articulo"].ToString();
                    row["Cantidad"] = registros["cant_articulo"].ToString();

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
            if (articulo.Text.Equals(""))
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

                MySqlCommand comando = new MySqlCommand("select id_articulos,nom_articulo,cant_articulo from articulos where id_articulos = " + articulo.Text, conexionBD.conectar);

                MySqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    DataRow row = dt.NewRow();

                    row["ID"] = registros["id_articulos"].ToString();
                    row["Nombre"] = registros["nom_articulo"].ToString();
                    row["Cantidad"] = registros["cant_articulo"].ToString();

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
