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
    public partial class citas : Form
    {
        public citas()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuMetroTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
         
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarAlumnos_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAAgregar_Click(object sender, EventArgs e)
        {
            RegistrarCita abrirRegistrarCitas = new RegistrarCita();
            abrirRegistrarCitas.Show();
        }

        private void btnLIniciarSesion_Click(object sender, EventArgs e)
        {
            ActualizarCita abrirActualizarCitas = new ActualizarCita();
            abrirActualizarCitas.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            MostrarAntigenos abrirMostrarAntigenos = new MostrarAntigenos();
            abrirMostrarAntigenos.Show();
        }
    }
}
