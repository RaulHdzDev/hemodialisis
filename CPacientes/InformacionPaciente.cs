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
    public partial class InformacionPaciente : Form
    {
        int idBuscar;
        public InformacionPaciente(int idBuscar)
        {
            this.idBuscar = idBuscar;
            InitializeComponent();
            mostrarPacientes();
            mostrarAlergias();
            mostrarEnfermedades();
            mostrarPadecimientos();
            
        }

        public void mostrarPacientes()
        {
            conexionBD.abrir();
            using (MySqlCommand comandoBuscar = new MySqlCommand("Select * from pacientes where id_pacientes = " + idBuscar, conexionBD.conectar))
            {
                MySqlDataReader reader = comandoBuscar.ExecuteReader();

                if (reader.Read())
                {
                    bunifuMetroTextbox1.Text    = reader.GetString(1);
                    bunifuMetroTextbox2.Text    = reader.GetString(2);
                    bunifuMetroTextbox3.Text    = reader.GetString(3);
                    bunifuMetroTextbox21.Text   = reader.GetString(4);
                    bunifuMetroTextbox20.Text   = reader.GetString(5);
                    comboBox1.Text              = reader.GetString(6);
                    bunifuMetroTextbox4.Text    = reader.GetString(7);
                    bunifuDatepicker2.Value     = reader.GetDateTime(8);
                    bunifuMetroTextbox19.Text   = reader.GetString(9);
                    bunifuMetroTextbox17.Text   = reader.GetString(10);
                    bunifuMetroTextbox18.Text   = reader.GetString(11);
                    bunifuMetroTextbox11.Text   = reader.GetString(12);
                    bunifuMetroTextbox5.Text    = reader.GetString(13);
                    bunifuMetroTextbox13.Text   = reader.GetString(14);
                    bunifuMetroTextbox6.Text    = reader.GetString(16);

                    label2.Text     = reader.GetString(1);
                    label55.Text    = reader.GetString(5);
                    label56.Text    = reader.GetString(4);
                    label57.Text    = reader.GetString(6);

                }
            }

            conexionBD.cerrar();
        }

        public void mostrarAlergias()
        {
            int idAlergias = 0;
            conexionBD.abrir();

            using (MySqlCommand comandoAlergias = new MySqlCommand("Select id_alergias from alergias_pacientes where id_pacientes = " + idBuscar,
                conexionBD.conectar))
            {
                MySqlDataReader reader = comandoAlergias.ExecuteReader();

                if (reader.Read())
                {
                    idAlergias = Int32.Parse(reader["id_alergias"].ToString());
                }
                reader.Close();
            }

            using (MySqlCommand comando = new MySqlCommand("Select alergia from alergias where id_alergias = " + idAlergias,
                        conexionBD.conectar))
            {
                MySqlDataReader leer = comando.ExecuteReader();

                if (leer.Read())
                {
                    bunifuMetroTextbox22.Text = leer.GetString(0);
                }
                leer.Close();
            }

            conexionBD.cerrar();
        }

        public void mostrarEnfermedades ()
        {
            int idEnfermedades = 0;
            conexionBD.abrir();

            using (MySqlCommand comandoEnfermedades = new MySqlCommand("Select id_enfermedades from enfermedades_pacientes where id_pacientes = " + idBuscar,
                conexionBD.conectar))
            {
                MySqlDataReader reader = comandoEnfermedades.ExecuteReader();

                if (reader.Read())
                {
                    idEnfermedades = Int32.Parse(reader["id_enfermedades"].ToString());
                }
                reader.Close();
            }

            using (MySqlCommand comando = new MySqlCommand("Select enfermedad from enfermedades where id_enfermedades = " + idEnfermedades,
                        conexionBD.conectar))
            {
                MySqlDataReader leer = comando.ExecuteReader();

                if (leer.Read())
                {
                    bunifuMetroTextbox16.Text = leer.GetString(0);
                }
                leer.Close();
            }

            conexionBD.cerrar();
        }

        public void mostrarPadecimientos ()
        {
            int idPadecimientos = 0;
            conexionBD.abrir();

            using (MySqlCommand comandoEnfermedades = new MySqlCommand("Select id_padecimientos from padecimientos_pacientes where id_pacientes = " + idBuscar,
                conexionBD.conectar))
            {
                MySqlDataReader reader = comandoEnfermedades.ExecuteReader();

                if (reader.Read())
                {
                    idPadecimientos = Int32.Parse(reader["id_padecimientos"].ToString());
                }
                reader.Close();
            }

            using (MySqlCommand comando = new MySqlCommand("Select padecimiento from padecimientos where id_padecimientos = " + idPadecimientos,
                        conexionBD.conectar))
            {
                MySqlDataReader leer = comando.ExecuteReader();

                if (leer.Read())
                {
                    bunifuMetroTextbox23.Text = leer.GetString(0);
                }
                leer.Close();
            }

            conexionBD.cerrar();
        }

        public void registrarNumerosEmergencia ()
        {
            conexionBD.abrir();
            if (comboBox2.Text != "")
            {
                string parentesco = comboBox2.Text;
                string numeroEmergencia = bunifuMetroTextbox15.Text;

                using (MySqlCommand comando = new MySqlCommand("Insert Into numeros_emergencias (id_pacientes, numeros_de_emergencias," +
                    "parentesco) Values (" + idBuscar + ",'" + numeroEmergencia + "','" + parentesco + "')", conexionBD.conectar))
                {
                    comando.ExecuteNonQuery();
                }

            }

            if (comboBox3.Text != "")
            {
                string parentesco = comboBox3.Text;
                string numeroEmergencia = bunifuMetroTextbox14.Text;

                using (MySqlCommand comando = new MySqlCommand("Insert Into numeros_emergencias (id_pacientes, numeros_de_emergencias," +
                    "parentesco) Values (" + idBuscar + ",'" + numeroEmergencia + "','" + parentesco + "')", conexionBD.conectar))
                {
                    comando.ExecuteNonQuery();
                }
            }


            if (comboBox5.Text != "")
            {
                string parentesco = comboBox5.Text;
                string numeroEmergencia = bunifuMetroTextbox8.Text;

                using (MySqlCommand comando = new MySqlCommand("Insert Into numeros_emergencias (id_pacientes, numeros_de_emergencias," +
                    "parentesco) Values (" + idBuscar + ",'" + numeroEmergencia + "','" + parentesco + "')", conexionBD.conectar))
                {
                    comando.ExecuteNonQuery();
                }
            }

            if (comboBox4.Text != "")
            {
                string parentesco = comboBox4.Text;
                string numeroEmergencia = bunifuMetroTextbox7.Text;

                using (MySqlCommand comando = new MySqlCommand("Insert Into numeros_emergencias (id_pacientes, numeros_de_emergencias," +
                    "parentesco) Values (" + idBuscar + ",'" + numeroEmergencia + "','" + parentesco + "')", conexionBD.conectar))
                {
                    comando.ExecuteNonQuery();
                }
            }
            conexionBD.cerrar();
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

        public void actualizarPadecimientos ()
        {
            string padecimientos = bunifuMetroTextbox23.Text;
            int idPadecimientos  = 0;

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

                default:
                    MessageBox.Show("Ingrese un padecimiento válido");
                    break;

            }

            using (MySqlCommand comandoPadecimientos = new MySqlCommand("update padecimientos_pacientes set id_padecimientos = " + idPadecimientos
                + "where id_pacientes = " + idBuscar, conexionBD.conectar))
            {
                comandoPadecimientos.ExecuteNonQuery();
                MessageBox.Show("Actualización exitosa");
                mostrarPadecimientos();
            }
            conexionBD.cerrar();
        }

        public void actualizarEnfermedades()
        {
            string enfermedades = bunifuMetroTextbox16.Text;
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
            using (MySqlCommand comandoPadecimientos = new MySqlCommand("update enfermedades_pacientes set id_enfermedades = " + idEnfermedades
                + "where id_pacientes = " + idBuscar, conexionBD.conectar))
            {
                comandoPadecimientos.ExecuteNonQuery();
                MessageBox.Show("Actualización exitosa");
                mostrarEnfermedades();
            }
            conexionBD.cerrar();

        }

        public void actualizarAlergias()
        {
            string alergias = bunifuMetroTextbox22.Text;
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

                default:
                    MessageBox.Show("Ingrese una alergia válida");
                    break;
            }

            MessageBox.Show(idAlergias.ToString() + idBuscar);
            using (MySqlCommand comandoAlergias = new MySqlCommand("update alergias_pacientes set id_alergias = " + idAlergias 
                + "where id_pacientes = " + idBuscar, conexionBD.conectar))
            {
                comandoAlergias.ExecuteNonQuery();
                MessageBox.Show("Actualización exitosa");

                mostrarAlergias();
            }
            conexionBD.cerrar();
        }

        public void actualizarPacientes()
        {
            conexionBD.abrir();

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
            string correo           = bunifuMetroTextbox6.Text;
            int NSS                 = Int32.Parse(bunifuMetroTextbox11.Text);
            string curp             = bunifuMetroTextbox5.Text;

            using (MySqlCommand comandoPacientes = new MySqlCommand ("Update pacientes set nombre = '" + nombre + "'," +
                "ape_pat = '" + apellidoMaterno + "'," +
                "ape_mat = '" + apellidoMaterno + "'," +
                "peso = '" + peso + "'," +
                "estatura = " + estatura + "," +
                "tipo_sangre = '" + tipoSangre + "'," +
                "num_ine = '" + numeroIne + "'," +
                "fecha_nacimiento = '" + fechaNacimiento + "'," +
                "hospital_origen = '" + hospitalOrigen + "'," +
                "diagnostico = '" + diagnostico + "'," +
                "observaciones = '" + observaciones + "'," +
                "num_seg = " + NSS + "," +
                "curp = '" + curp + "'," +
                "num_contacto_cel = '" + celular + "'," +
                "correo_electronico = '" + correo + "'" +
                "where id_pacientes = " + idBuscar, conexionBD.conectar
                )) {

                comandoPacientes.ExecuteNonQuery();
                MessageBox.Show("Actualizado Pacientes");
                mostrarPacientes();

            }
            conexionBD.cerrar();
        }

        private void BtnLIniciarSesion_Click(object sender, EventArgs e)
        {
            actualizarPacientes();
            registrarNumerosEmergencia();
        }

        private void Label55_Click(object sender, EventArgs e)
        {

        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            conexionBD.abrir();

            using (MySqlCommand comando = new MySqlCommand ("delete from pacientes where id_pacientes = " + idBuscar, conexionBD.conectar))
            {
                comando.ExecuteNonQuery();
                conexionBD.cerrar();
                this.Hide();
            }
        }
    }
}
