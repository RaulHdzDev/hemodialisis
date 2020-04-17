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
    public partial class MostrarAntigenos : Form
    {
        String idCita = "";
        String idEmpleado = "";
        String TipoAcceso = "";
        String Antigeno = "";
        String idTipoAcceso = "";
        String idAntigeno = "";
        String Fecha = "";
        String idArticulos = "";
        int cantArticulos = 0;

        public MostrarAntigenos(String id)
        {
            InitializeComponent();
            idCita = id;
            Cargar();
        }

        public void Cargar()
        {
            nombresAnti();
            nombresAcceso();
            idsEmpleado();
        }

        public void idsEmpleado()
        {
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("select id_empleados from citas Where id_citas = " + idCita, conexionBD.conectar);

                MySqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    idEmpleado = registros["id_empleados"].ToString();
                }

                conexionBD.cerrar();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al solicitar informacion " + e);
            }
        }

        public void nombresAnti()
        {
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("select nom_antigeno from antigenos", conexionBD.conectar);

                MySqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    String anti = registros["nom_antigeno"].ToString();
                    cbAntiMAnti.Items.Add(anti);
                }

                conexionBD.cerrar();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al solicitar informacion " + e);
            }
        }

        public void nombresAcceso()
        {
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("select acceso from tipos_accesos", conexionBD.conectar);

                MySqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    String acceso = registros["acceso"].ToString();
                    cbAccesoMAnti.Items.Add(acceso);
                    //agregar a combobox
                }

                conexionBD.cerrar();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al solicitar informacion " + e);
            }
        }


        //codigo para poder arrastrar la ventana por la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //codigo para poder arrastrar la ventana por la pantalla

        private void MostrarAntigenos_Load(object sender, EventArgs e)
        {

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

        private void MostrarAntigenos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLIniciarSesion_Click(object sender, EventArgs e)
        {
                //realizar el registro en tabla citas_accesos_antigenos
                guardar();
                //realizar el registro en tabla bitacora y hacer update en tabla de articulos
                bitacora(chbCubreBocas.Text.ToString(), chbCubreBocas.Checked, Int32.Parse(cantCubreBocas.Text.ToString()));
                bitacora(chbCircuito.Text.ToString(), chbCircuito.Checked, Int32.Parse(cantCircuitos.Text.ToString()));
                bitacora(chbFAVI.Text.ToString(), chbFAVI.Checked, Int32.Parse(cantAguFAVI.Text.ToString()));
                bitacora(chbFiltro.Text.ToString(), chbFiltro.Checked, Int32.Parse(cantFiltro.Text.ToString()));
                bitacora(chbGasas.Text.ToString(), chbGasas.Checked, Int32.Parse(cantGasas.Text.ToString()));
                bitacora(chbGuantes.Text.ToString(), chbGuantes.Checked, Int32.Parse(cantGuantes.Text.ToString()));
                bitacora(chbHeparina.Text.ToString(), chbHeparina.Checked, Int32.Parse(cantHeparina.Text.ToString()));
                bitacora(chbJerin10.Text.ToString(), chbJerin10.Checked, Int32.Parse(cantJeringas10.Text.ToString()));
                bitacora(chbJerin20.Text.ToString(), chbJerin20.Checked, Int32.Parse(cantJeringas20.Text.ToString()));
                bitacora(chbJerin3.Text.ToString(), chbJerin3.Checked, Int32.Parse(cantJeringas3.Text.ToString()));
                bitacora(chbMicro.Text.ToString(), chbMicro.Checked, Int32.Parse(cantMicropore.Text.ToString()));
                bitacora(chbMicrodacyn.Text.ToString(), chbMicrodacyn.Checked, Int32.Parse(cantMicrodacyn.Text.ToString()));
                bitacora(chbSolSal.Text.ToString(), chbSolSal.Checked, Int32.Parse(cantSolSal.Text.ToString()));
                bitacora(chbTela.Text.ToString(), chbTela.Checked, Int32.Parse(cantTelaAd.Text.ToString()));
            this.Hide();
        }

        public void bitacora(String nombre, bool afirmacion, int cantidad)
        {
            if (afirmacion)
            {
                //Consulta tabla articulos
                consultaArticulos(nombre);
                //contabiliza la cantidad de articulos
                if (cantArticulos >= cantidad)
                {
                    //Guardar en tabla bitacora
                    try
                    {
                        conexionBD.abrir();

                        MySqlCommand comando = new MySqlCommand("insert into bitacora (id_empleados, id_articulos, cantidad) " +
                            "values('" + idEmpleado + "', '" + idArticulos + "', '" + cantidad + "')", conexionBD.conectar);

                        comando.ExecuteNonQuery();

                        conexionBD.cerrar();

                        MessageBox.Show("Registro exitoso");

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Error al solicitar el registro. Por favor intentelo mas tarde" + e.Message);
                    }
                    //actualizar tabla articulos
                    cantArticulos = cantArticulos - cantidad;
                    actArticulos();
                }
                else
                {
                    MessageBox.Show("No hay suficiente material");
                }
            }
                
        }

        public void consultaArticulos(String nombre)
        {
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("select id_articulos, cant_articulo from articulos " +
                    "where nom_articulo = '" + nombre + "';", conexionBD.conectar);

                MySqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    idArticulos = registros["id_articulos"].ToString();
                    cantArticulos = Int32.Parse(registros["cant_articulo"].ToString());
                }

                conexionBD.cerrar();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al solicitar informacion");
            }
        }

        public void actArticulos()
        {
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("update articulos set cant_articulo = " + cantArticulos + " where id_articulos = " + idArticulos, conexionBD.conectar);

                comando.ExecuteNonQuery();

                conexionBD.cerrar();

                //MessageBox.Show("Update exitoso");

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al solicitar el update. Por favor intentelo mas tarde. ");
            }
        }

        public void guardar()
        {
            Antigeno = cbAntiMAnti.Text;
            TipoAcceso = cbAccesoMAnti.Text;
            idsAcceso();
            idsAnti();
            String Fecha2 = DateTime.Now.ToShortDateString();
            String fechaAño = Fecha2.Substring(7);
            String fechaMes = Fecha2.Substring(3, 4);
            String fechaDia = Fecha2.Substring(0, 1);
            Fecha = fechaAño + "/" + fechaMes + "/" + fechaDia;
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("insert into citas_accesos_antigenos (id_citas, id_antigenos, id_tipos_accesos, fecha_aplicacion) " +
                    "values(" + idCita + ", " + idAntigeno + ", " + idTipoAcceso + ", '" + Fecha + "')", conexionBD.conectar);

                comando.ExecuteNonQuery();

                conexionBD.cerrar();

                //MessageBox.Show("Registro exitoso");

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al solicitar el registro. Por favor intentelo mas tarde");
            }
        }

        public void idsAcceso()
        {
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("select id_tipos_accesos from tipos_accesos " +
                    "where acceso = '" + TipoAcceso + "';", conexionBD.conectar);

                MySqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    idTipoAcceso = registros["id_tipos_accesos"].ToString();
                }

                conexionBD.cerrar();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al solicitar informacion");
            }
        }

        public void idsAnti()
        {
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("select id_antigenos from antigenos " +
                    "where nom_antigeno = '" + Antigeno + "';", conexionBD.conectar);

                MySqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    idAntigeno = registros["id_antigenos"].ToString();
                }

                conexionBD.cerrar();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al solicitar informacion");
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
