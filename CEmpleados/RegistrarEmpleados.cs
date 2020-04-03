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
    public partial class Registr : Form
    {
        public Registr()
        {
            InitializeComponent();
        }

        private void RegistrarEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Registrar();
        }

        private void btnAAgregar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Registrar()
        {
            try
            {
                conexionBD.abrir();

                MySqlCommand comando = new MySqlCommand("insert into empleados(nombre, ape_pat, ape_mat, edad, calle, num_ext, num_int, colonia, tipo_empleado, correo, cedula_prof, num_tel) values('" + nombre.Text + "','" + apellidoP.Text + "','" + apellidoM.Text + "'," + edad.Text + "," + calle.Text + "," + numeroE.Text + "," + numeroI.Text + "," + colonia.Text + ",'" + tipoE.SelectedItem.ToString() + "', '" + correo.Text + "', " + cedulaP.Text + ", "+telefono.Text+")", conexionBD.conectar);

                comando.ExecuteNonQuery();

                conexionBD.cerrar();

                MessageBox.Show("Registro exitoso");

                Limpiar();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al solicitar el registro. Por favor intentelo mas tarde" + e.Message);
            }

        }

        public void Limpiar()
        {
            nombre.Text = "";
            apellidoP.Text = "";
            apellidoM.Text = "";
            edad.Text = "";
            calle.Text = "";
            numeroE.Text = "";
            numeroI.Text = "";
            colonia.Text = "";
            correo.Text = "";
            cedulaP.Text = "";
            telefono.Text = "";
        }
    }
}
