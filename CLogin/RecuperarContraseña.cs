using MySql.Data.MySqlClient;
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
using Talent.negocios;

namespace Talent
{
    public partial class RecuperarContraseña : Form
    {
        private string correo;
        MetodoRecuperarContraseña recuperarcontraseñaobjeto = new MetodoRecuperarContraseña();
        public RecuperarContraseña()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
          
            correo = txt_user.text;

            MySqlDataReader msdr = null;

            try
            {

                using (MySqlCommand comando = new MySqlCommand("Select correo from usuarios where correo = '" + correo.Trim() + "'", conexionBD.conectar))
                {
                    msdr = comando.ExecuteReader();

                    if (msdr.Read())
                    {
                        recuperarcontraseñaobjeto.metodo(correo);
                        MessageBox.Show("Correo enviado");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un correo existente");
                    }
                    msdr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void Inscribir_Load(object sender, EventArgs e)
        {

        }

        private void TxtRCorreo_Enter(object sender, EventArgs e)
        {
           
        }

        private void TxtRCorreo_Leave(object sender, EventArgs e)
        {
           
        }
    }
}
