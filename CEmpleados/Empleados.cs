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
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {

        }

        private void btnAAgregar_Click(object sender, EventArgs e)
        {
            Registr abrirEmpleados = new Registr();
            abrirEmpleados.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLIniciarSesion_Click(object sender, EventArgs e)
        {
            InformacionEmpleado abrirInfoEmpleados = new InformacionEmpleado();
            abrirInfoEmpleados.Show();

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            RegistrarRH abrirRegistrarRH = new RegistrarRH();
            abrirRegistrarRH.Show();
        }
    }
}
