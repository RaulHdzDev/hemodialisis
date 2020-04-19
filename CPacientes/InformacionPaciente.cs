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
    public partial class InformacionPaciente : Form
    {
        public InformacionPaciente()
        {
            InitializeComponent();
        }

        private void InformacionPaciente_Load(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void panel9_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAAgregar_Click(object sender, EventArgs e)
        {
            InformacionMedica abrirInformacionMedica = new InformacionMedica();
            abrirInformacionMedica.Show();
        }
    }
}
