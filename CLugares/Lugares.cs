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
    public partial class Lugares : Form
    {
        public Lugares()
        {
            InitializeComponent();
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
            ActualizarLugar abrirActualizarLugar = new ActualizarLugar();
            abrirActualizarLugar.Show();
        }
    }
}
