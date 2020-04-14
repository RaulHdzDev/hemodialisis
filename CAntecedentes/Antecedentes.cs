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
    public partial class Antecedentes : Form
    {
        public Antecedentes()
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
           /* RegistrarAntecedentes abrirRegistrarAntecedentes = new RegistrarAntecedentes();
            abrirRegistrarAntecedentes.Show();
            */

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            /*
            ActualizarAntecedente abrirActualizar= new ActualizarAntecedente();
            abrirActualizar.Show();
            */
        }

        private void btnLIniciarSesion_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
