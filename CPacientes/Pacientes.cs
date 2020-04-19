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

namespace Talent
{
    public partial class Paciente : Form
    {
        public Paciente()
        {
            InitializeComponent();
            mostrarPacientes();
        }

        public void mostrarPacientes ()
        {
            try
            {
                using (MySqlCommand comando = new MySqlCommand("Select * From pacientes", conexionBD.conectar))
                {
                    MySqlDataAdapter msda = new MySqlDataAdapter();
                    msda.SelectCommand = comando;
                    DataTable dt = new DataTable();
                    msda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void Grafica_Load_1(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {           
            RegistrarPaciente AbrirRegistrar = new RegistrarPaciente();
            AbrirRegistrar.Show();          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLIniciarSesion_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txt_user.text);
            InformacionPaciente AbrirInformacionPaciente = new InformacionPaciente(id);
            AbrirInformacionPaciente.Show();          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PictureBox2_Click_2(object sender, EventArgs e)
        {
            try
            {
                using (MySqlCommand comando = new MySqlCommand("Select * From pacientes where id_pacientes = " + txt_user.text, conexionBD.conectar))
                {
                    MySqlDataAdapter msda = new MySqlDataAdapter();
                    msda.SelectCommand = comando;
                    DataTable dt = new DataTable();
                    msda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
    }
    }
