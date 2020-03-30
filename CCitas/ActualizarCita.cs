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
    public partial class ActualizarCita : Form
    {
        public ActualizarCita()
        {
            InitializeComponent();
        }

        private void ActualizarCita_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelarActualizar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
