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
    public partial class aux : Form
    {
        public aux()
        {
            InitializeComponent();
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
            ActualizarArticulo AbrirActualiar = new ActualizarArticulo();
            AbrirActualiar.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
