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
    public partial class RegistrarAdmin : Form
    {
        public RegistrarAdmin()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegistrarAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnLIniciarSesion_Click(object sender, EventArgs e)
        {
            Form regresarlogin = new Login();
            this.Hide();
            regresarlogin.Show();
        }
    }
}
