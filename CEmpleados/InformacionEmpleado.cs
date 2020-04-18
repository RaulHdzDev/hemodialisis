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
    public partial class InformacionEmpleado : Form
    {
        String idEmpleado;

        public InformacionEmpleado(string id)
        {
            InitializeComponent();
            idEmpleado = id;
            Cargar();
        }

        private void InformacionEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton24_Click_1(object sender, EventArgs e)
        {
        
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        public void Actualizar()
        {
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("update empleados set nombre = '" + nombre.Text + "',ape_pat = '" + apellidoP.Text + "', ape_mat = '" + apellidoM.Text + "', edad = " + edad.Text + ", colonia = '" + colonia.Text + "', calle = '" + calle.Text + "', num_ext = " + numeroE.Text + ", num_int = " + numeroI.Text + ", tipo_empleado = '" + tipoE.SelectedItem.ToString() + "', correo = '" + correo.Text + "', cedula_prof = '" + cedulaP.Text + "', num_tel = '"+telefono.Text+"' where id_empleados = " + idEmpleado, conexionBD.conectar);

                comando.ExecuteNonQuery();

                conexionBD.cerrar();

                MessageBox.Show("Update exitoso");

                label2.Text = nombre.Text;
                label4.Text = edad.Text;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al solicitar el update. Por favor intentelo mas tarde");
            }

        }

        public void Cargar()
        {
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("select nombre,ape_pat,ape_mat,tipo_empleado,edad,colonia,num_ext,num_int,calle,correo,cedula_prof, num_tel from empleados where id_empleados = " + idEmpleado, conexionBD.conectar);

                MySqlDataReader registros = comando.ExecuteReader();


                while (registros.Read())
                {
                    nombre.Text = registros["nombre"].ToString();
                    apellidoP.Text = registros["ape_pat"].ToString();
                    apellidoM.Text = registros["ape_mat"].ToString();
                    edad.Text = registros["edad"].ToString();
                    colonia.Text = registros["colonia"].ToString();
                    calle.Text = registros["calle"].ToString();
                    numeroE.Text = registros["num_ext"].ToString();
                    numeroI.Text = registros["num_int"].ToString();
                    tipoE.Text = registros["tipo_empleado"].ToString();
                    correo.Text = registros["correo"].ToString();
                    cedulaP.Text = registros["cedula_prof"].ToString();
                    telefono.Text = registros["num_tel"].ToString();

                    label2.Text = nombre.Text;
                    label4.Text = edad.Text;
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

                MySqlCommand comando = new MySqlCommand("delete from empleados where id_empleados = " + idEmpleado, conexionBD.conectar);

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
