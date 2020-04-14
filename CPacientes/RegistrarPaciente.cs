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
    public partial class RegistrarPaciente : Form
    {
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
            conexionBD.abrir();

            //table pacientes
            string nombre = nombreTxt.Text;
            string apellidoPaterno = apellidoPaternoTxt.Text;
            string apellidoMaterno = apellidoMaternoTxt.Text;
            //int edad = Int32.Parse(edadTxt.Text);
            string peso = pesoTxt.Text;
            int estatura = Int32.Parse(estaturaTxt.Text);
            string numeroIne = IneTxt.Text;


            string fechaIngreso = ingreso.Value.ToString("yyyy-MM-dd");
            //fechaIngreso.ToString("yyyy-MM-dd");
            string fechaNacimiento = fechaNac.Value.ToString("yyyy-MM-dd");
            //fechaNacimiento.ToString("yyyy-MM-dd");
            string fechaExamen = examen.Value.ToString("yyyy-MM-dd");

            string hospitalOrigen = hospitalTxt.Text;
            string diagnostico = diagnosticoTxt.Text;
            string observaciones = observacionesTxt.Text;
            int numeroSeguroSocial = Int32.Parse(numero.Text);
            string curp = curpTxt.Text;
            string numContactoCel = cel.Text;
            string numContactoTel = tel.Text;
            string correo = correoTxt.Text;
            string codigo = codigoTxt.Text;
            string tipoSangre = sangreTxt.Text;

            /*table accesos
            string fechaInstalacion = instalacion.Value.ToString("yyyy-MM-dd");
            //fechaInstalacion.ToString("yyyy-MM-dd");

            //table alergias 
            string alergias = alergiasTxt.Text;

            //table padecimientos
            string padecimientos = padecimientosTxt.Text;

            //table tipos_accesos
            string tipoAccesoVascular = accesoVascular.Text;

            //tipos_sangres

            //table antigenos
            string antigenosTomados = antigenosTomadosTxt.Text;
            //fechaExamen.ToString("yyyy-MM-dd");

            //table enfermedades
            string enfermedades = enfermedadesTxt.Text; */

            using (MySqlCommand comandoPacientes = new MySqlCommand("Insert Into pacientes (nombre, ape_pat, ape_mat, peso," +
                "estatura, tipo_sangre, num_ine, fecha_nacimiento, hospital_origen, diagnostico, observaciones, num_seg, " +
                "curp, num_contacto_cel, num_contacto_tel, correo_electronico, codigo) Values ('" + nombre + "','" + apellidoPaterno
                + "','" + apellidoMaterno + "','" + peso + "'," + estatura + ",'" + tipoSangre + "','" + numeroIne + "','"
                + fechaNacimiento + "','" + hospitalOrigen + "','" + diagnostico + "','" + observaciones
                + "'," + numeroSeguroSocial + ",'" + curp + "','" + numContactoCel + "','" + numContactoTel + "','" + correo + "','" + codigo + "')",
                conexionBD.conectar))
            {
                comandoPacientes.ExecuteNonQuery();
                this.Hide();
                /*if(mysqldrPacientes.RecordsAffected == 1)
                {
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("No registrado");
                }
                mysqldrPacientes.Close();*/

            }

            /* using (MySqlCommand comandoAccesos = new MySqlCommand("Insert Into accesos (fecha_instalacion) Values ('" + fechaInstalacion + "')", 
                   conexionBD.conectar))
            {
                comandoAccesos.ExecuteNonQuery();
                
            } 

            using (MySqlCommand comandoAlergias = new MySqlCommand ("Insert Into alergias (alergia) Values ('" + alergias + "')",
                conexionBD.conectar))
            {
                comandoAlergias.ExecuteNonQuery();
                
            }

            using (MySqlCommand comandoPadecimientos = new MySqlCommand ("Insert Into padecimientos (padecimiento) Values ('" + padecimientos + "')",
                conexionBD.conectar))
            {
                comandoPadecimientos.ExecuteNonQuery();
                
            }

            using (MySqlCommand comandoTiposAccesos = new MySqlCommand("Insert Into tipos_accesos (acceso) Values ('" + tipoAccesoVascular + "')",
                conexionBD.conectar))
            {
                comandoTiposAccesos.ExecuteNonQuery();
                
            }

            using (MySqlCommand comandoSangres = new MySqlCommand("Insert Into tipos_sangres (tipos_sangres) Values ('" + tipoSangre + "')",
                conexionBD.conectar))
            {
                comandoSangres.ExecuteNonQuery();
                
            }

            using (MySqlCommand comandoAntigenos = new MySqlCommand("Insert Into antigenos (nom_antigeno) Values ('" + antigenosTomados + "')",
                conexionBD.conectar))
            {
                comandoAntigenos.ExecuteNonQuery();
                
            }

            using (MySqlCommand comandoEnfermedades = new MySqlCommand("Insert Into enfermedades (enfermedad) Values ('" + enfermedades + "')",
                conexionBD.conectar))
            {
                comandoEnfermedades.ExecuteNonQuery();
                
            } */
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
    }
}
