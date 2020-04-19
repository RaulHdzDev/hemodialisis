using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Talent.datos;
using MySql.Data.MySqlClient;

namespace Talent
{
    public partial class RegistrarPaciente : Form
    {
        int id = 0;
        public RegistrarPaciente()
        {
            InitializeComponent();
     
        }

        //codigo para poder arrastrar la ventana por la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //codigo para poder arrastrar la ventana por la pantalla




        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
          
        }

        private void Horario_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BunifuMetroTextbox10_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void panelInferior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {

        }

        private void panelSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void panelInterno1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuMetroTextbox7_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click_2(object sender, EventArgs e)
        {
            string nombre           = bunifuMetroTextbox1.Text;
            string apellidoPaterno  = bunifuMetroTextbox2.Text;
            string apellidoMaterno  = bunifuMetroTextbox3.Text;
            string peso             = bunifuMetroTextbox21.Text;
            int estatura            = Int32.Parse(bunifuMetroTextbox20.Text);
            string tipoSangre       = comboBox1.Text;
            string numeroIne        = bunifuMetroTextbox4.Text;
            string fechaNacimiento  = bunifuDatepicker2.Value.ToString("yyyy-MM-dd");
            string hospitalOrigen   = bunifuMetroTextbox19.Text;
            string diagnostico      = bunifuMetroTextbox17.Text;
            string observaciones    = bunifuMetroTextbox18.Text;
            string celular          = bunifuMetroTextbox13.Text;
            string telefono         = bunifuMetroTextbox16.Text;
            string correo           = bunifuMetroTextbox6.Text;
            int NSS                 = Int32.Parse(bunifuMetroTextbox12.Text);
            string curp             = bunifuMetroTextbox5.Text;
            string codigo           = curp.Substring(0, 4) + NSS.ToString().Substring(0, 4);

            conexionBD.abrir();

            using (MySqlCommand comando = new MySqlCommand("Insert Into pacientes (nombre, ape_pat, ape_mat, peso," +
               "estatura, tipo_sangre, num_ine, fecha_nacimiento, hospital_origen, diagnostico, observaciones, num_seg, " +
               "curp, num_contacto_cel, num_contacto_tel, correo_electronico, codigo) " +
               "Values ('" + nombre + "','" + apellidoPaterno + "','" + apellidoMaterno + "','" + peso + "'," + estatura + ",'" 
               + tipoSangre + "','" + numeroIne + "','" + fechaNacimiento + "','" + hospitalOrigen + "','" + diagnostico + "','" + observaciones
               + "'," + NSS + ",'" + curp + "','" + celular + "','" + telefono + "','" + correo + "','" + codigo + "')", conexionBD.conectar))
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Se a registrado el paciente con éxito");
                this.Hide();
            }

            using (MySqlCommand comandoId = new MySqlCommand("Select id_pacientes from pacientes where codigo = '" + codigo + "'", conexionBD.conectar))
            {
                MySqlDataReader msqldr = comandoId.ExecuteReader();
                msqldr.Read();
                id = Int32.Parse(msqldr["id_pacientes"].ToString());
                msqldr.Close();
            }


        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void bunifuThinButton22_Click_2(object sender, EventArgs e)
        {
            InformacionMedica abrirInformacionMedica = new InformacionMedica(id);
            abrirInformacionMedica.Show();
        }

        private void btnAAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuDatepicker2_onValueChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelVerNEmergencias_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
       

            }


    }
}
