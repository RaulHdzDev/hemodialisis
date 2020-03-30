using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Talent
{
    public partial class RecuperarContraseña : Form
    {
        public RecuperarContraseña()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Favor de revisar su correo");
            this.Hide();
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
