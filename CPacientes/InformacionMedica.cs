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
using MySql.Data.MySqlClient;
using Talent.datos;

namespace Talent
{
    public partial class InformacionMedica : Form
    {
        int id;
        public InformacionMedica(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        //codigo para poder arrastrar la ventana por la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //codigo para poder arrastrar la ventana por la pantalla


        
    
        private void InformacionMedica_Load(object sender, EventArgs e)
        {

        }

        private void btnAAgregar_Click(object sender, EventArgs e)
        {
            conexionBD.abrir();

            foreach (string alergias in checkedListBox1.CheckedItems)
            {
                int idAlergias = 0;

                switch (alergias)
                {

                    case "Rinitis":
                        idAlergias = 1;
                        break;

                    case "Asma":
                        idAlergias = 2;
                        break;

                    case "Urticaria":
                        idAlergias = 3;
                        break;

                    case "Dermatitis atópica":
                        idAlergias = 4;
                        break;

                    case "Dermatitis por contacto":
                        idAlergias = 5;
                        break;

                    case "Alimenticias":
                        idAlergias = 6;
                        break;

                    case "Desconocido":
                        idAlergias = 8;
                        break;
                }

                using (MySqlCommand comandoAlergias = new MySqlCommand("Insert Into alergias_pacientes (id_alergias, id_pacientes) " +
                    "Values (" + idAlergias + "," + id + ")", conexionBD.conectar))
                {
                    comandoAlergias.ExecuteNonQuery();
                }

            }

            foreach (string enfermedades in checkedListBox2.CheckedItems)
            {
                int idEnfermedades = 0;

                switch (enfermedades)
                {

                    case "Gripa":
                        idEnfermedades = 1;
                        break;

                    case "Diabetes":
                        idEnfermedades = 2;
                        break;

                    case "Vitíligo":
                        idEnfermedades = 3;
                        break;

                    case "Arritmia":
                        idEnfermedades = 4;
                        break;

                    case "Aneurisma":
                        idEnfermedades = 5;
                        break;

                    case "Lupus":
                        idEnfermedades = 6;
                        break;

                    case "Menopausia":
                        idEnfermedades = 7;
                        break;

                    case "Cáncer de mama":
                        idEnfermedades = 8;
                        break;

                    case "Vaginitis":
                        idEnfermedades = 9;
                        break;

                    case "Acné":
                        idEnfermedades = 10;
                        break;

                    case "Ampollas":
                        idEnfermedades = 11;
                        break;

                    case "Herpes":
                        idEnfermedades = 12;
                        break;

                    case "Melanoma":
                        idEnfermedades = 13;
                        break;

                    case "Urticaria":
                        idEnfermedades = 14;
                        break;

                    case "Anemia":
                        idEnfermedades = 15;
                        break;

                    case "Leucemia":
                        idEnfermedades = 16;
                        break;

                    case "Cataratas":
                        idEnfermedades = 17;
                        break;

                    case "Miopía":
                        idEnfermedades = 18;
                        break;

                    case "SIDA":
                        idEnfermedades = 19;
                        break;

                    case "Desconocido":
                        idEnfermedades = 20;
                        break;

                }

                using (MySqlCommand comandoEnfermedades = new MySqlCommand("Insert Into enfermedades_pacientes (id_enfermedades, id_pacientes) " +
                    "Values (" + idEnfermedades + "," + id + ")", conexionBD.conectar))
                {
                    comandoEnfermedades.ExecuteNonQuery();
                }
            }

            foreach (string padecimientos in checkedListBox3.CheckedItems)
            {
                int idPadecimientos = 0;

                switch (padecimientos)
                {

                    case "Hipertensión":
                        idPadecimientos = 1;
                        break;

                    case "Rinosinusitis crónica":
                        idPadecimientos = 2;
                        break;

                    case "Malformaciones congénitas de oído":
                        idPadecimientos = 3;
                        break;

                    case "Vértigo de cualquier etiología":
                        idPadecimientos = 4;
                        break;

                    case "Amigdalitis obstructiva":
                        idPadecimientos = 5;
                        break;

                    case "Parálisis facial":
                        idPadecimientos = 6;
                        break;

                    case "Tumores":
                        idPadecimientos = 7;
                        break;

                    case "Parafimosis":
                        idPadecimientos = 8;
                        break;

                    case "Hemorroides":
                        idPadecimientos = 9;
                        break;

                    case "Ginecomastia":
                        idPadecimientos = 10;
                        break;

                    case "Lipomas":
                        idPadecimientos = 11;
                        break;

                    case "Insuficiencia venosa":
                        idPadecimientos = 12;
                        break;

                    case "Embarazo":
                        idPadecimientos = 13;
                        break;

                    case "Cáncer":
                        idPadecimientos = 14;
                        break;

                    case "Discromatopsia":
                        idPadecimientos = 15;
                        break;

                    case "Hipertiroidismo":
                        idPadecimientos = 16;
                        break;

                    case "Hipotiroidismo":
                        idPadecimientos = 17;
                        break;

                    case "Disfemias":
                        idPadecimientos = 18;
                        break;

                    case "Escotomas":
                        idPadecimientos = 19;
                        break;

                    case "Cistitis":
                        idPadecimientos = 20;
                        break;

                    case "Desconocido":
                        idPadecimientos = 22;
                        break;

                }

                using (MySqlCommand comandoEnfermedades = new MySqlCommand("Insert Into padecimientos_pacientes (id_padecimientos, id_pacientes) " +
                    "Values (" + idPadecimientos + "," + id + ")", conexionBD.conectar))
                {
                    comandoEnfermedades.ExecuteNonQuery();
                }
            }

            conexionBD.cerrar();
            this.Hide();
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InformacionMedica_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
