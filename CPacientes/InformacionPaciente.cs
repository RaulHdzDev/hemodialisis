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
            mostrarPadecimientos();
            mostrarEnfermedades();
            mostrarAlergias();

            
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

        public void mostrarEnfermedades()
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

        public void mostrarPadecimientos()
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

        public void actualizarPacientes()
        {
            conexionBD.abrir();

            string nombre = bunifuMetroTextbox10.Text;
            string apellidoPaterno = bunifuMetroTextbox9.Text;
            string apellidoMaterno = bunifuMetroTextbox3.Text;
            string peso = bunifuMetroTextbox21.Text;
            int estatura = Int32.Parse(bunifuMetroTextbox20.Text);
            string tipoSangre = comboBox1.Text;
            string numeroIne = bunifuMetroTextbox4.Text;
            string fechaNacimiento = bunifuDatepicker2.Value.ToString("yyyy-MM-dd");
            string hospitalOrigen = bunifuMetroTextbox19.Text;
            string diagnostico = bunifuMetroTextbox17.Text;
            string observaciones = bunifuMetroTextbox18.Text;
            string celular = bunifuMetroTextbox13.Text;
            string telefono = bunifuMetroTextbox1.Text;
            string correo = bunifuMetroTextbox6.Text;
            int NSS = Int32.Parse(bunifuMetroTextbox12.Text);
            string curp = bunifuMetroTextbox5.Text;

            using (MySqlCommand comandoPacientes = new MySqlCommand("Update pacientes set nombre = '" + nombre + "'," +
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
                "num_contacto_tel = '" + telefono + "'," +
                "correo_electronico = '" + correo + "'" +
                "where id_pacientes = " + idBuscar, conexionBD.conectar
                ))
            {

                comandoPacientes.ExecuteNonQuery();
                MessageBox.Show("Actualizado Pacientes");
                mostrarPacientes();

            }
            conexionBD.cerrar();
        }


        public void mostrarPacientes()
        {
            conexionBD.abrir();

            using (MySqlCommand comandoBuscar = new MySqlCommand("Select * from pacientes where id_pacientes = " + idBuscar, conexionBD.conectar))
            {
                MySqlDataReader reader = comandoBuscar.ExecuteReader();

                if (reader.Read())
                {
                    bunifuMetroTextbox10.Text   = reader.GetString(1);
                    bunifuMetroTextbox9.Text    = reader.GetString(2);
                    bunifuMetroTextbox3.Text    = reader.GetString(3);
                    bunifuMetroTextbox21.Text   = reader.GetString(4);
                    bunifuMetroTextbox20.Text   = reader.GetString(5);
                    comboBox1.Text              = reader.GetString(6);
                    bunifuMetroTextbox4.Text    = reader.GetString(7);
                    bunifuDatepicker2.Value     = reader.GetDateTime(8);
                    bunifuMetroTextbox19.Text   = reader.GetString(9);
                    bunifuMetroTextbox17.Text   = reader.GetString(10);
                    bunifuMetroTextbox18.Text   = reader.GetString(11);
                    bunifuMetroTextbox12.Text   = reader.GetString(12);
                    bunifuMetroTextbox5.Text    = reader.GetString(13);
                    bunifuMetroTextbox13.Text   = reader.GetString(14);
                    bunifuMetroTextbox1.Text    = reader.GetString(15);
                    bunifuMetroTextbox6.Text    = reader.GetString(16);

                    label2.Text     = reader.GetString(1);
                    label55.Text    = reader.GetString(5);
                    label56.Text    = reader.GetString(4);
                    label57.Text    = reader.GetString(6);
                }
            }
            conexionBD.cerrar();
        }

        public void registrarNumerosEmergencias()
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
            this.Hide();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAAgregar_Click(object sender, EventArgs e)
        {

            InformacionMedica abrirInformacionMedica = new InformacionMedica(idBuscar);
            abrirInformacionMedica.Show();
        }

        private void BunifuMetroTextbox10_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnLIniciarSesion_Click(object sender, EventArgs e)
        {
            registrarNumerosEmergencias();
            actualizarPacientes();
            this.Hide();
        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            conexionBD.abrir();

            using (MySqlCommand comando = new MySqlCommand("delete from pacientes where id_pacientes = " + idBuscar, conexionBD.conectar))
            {
                comando.ExecuteNonQuery();
                conexionBD.cerrar();
                this.Hide();
            }
        }

        private void BunifuMetroTextbox8_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
