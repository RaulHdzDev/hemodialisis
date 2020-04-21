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
    public partial class VentanaPrincipal : Form
    {

        String TipoUsuario = "";
        bool permisoCita = false;
        bool permisoAnte = false;
        bool permisoPaci = false;
        bool permisoEmple = false;
        bool permisoInicio = false;
        bool permisoCami = false;
        bool permisoAlmacen = false;
        bool permisoBitacora = false;

        public VentanaPrincipal(String id)
        {
            InitializeComponent();
            TipoUsuario = id;
            CargarPermisos();
            eliminarCitas();
        }

        public void eliminarCitas()
        {
            conexionBD.abrir();
            try
            {
                using (MySqlCommand comando = new MySqlCommand("Select id_citas from vista_citas_incompletas", conexionBD.conectar))
                {
                    MySqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {

                        int id = Int32.Parse(reader.GetString(0));
                        reader.Close();
                        using (MySqlCommand comandoBorrar = new MySqlCommand("delete from citas where id_citas = " + id, conexionBD.conectar))
                        {
                            comandoBorrar.ExecuteNonQuery();
                        }
                        if (reader != null)
                        {
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            conexionBD.cerrar();
        }




        private void CargarPermisos()
        {
            switch (TipoUsuario)
            {
                case "Doctor":
                case "Enfermera":
                    permisoCita = true;
                    permisoPaci = true;
                    permisoInicio = true;
                    permisoAnte = true;
                    break;
                case "RH":
                    permisoEmple = true;
                    permisoInicio = true;
                    break;
                case "Pasante":
                    permisoInicio = true;
                    break;
                case "Administrativo":
                    permisoCami = true;
                    permisoAlmacen = true;
                    permisoInicio = true;
                    break;
                case "Secretaria":
                case "Intendente":
                    //permisoCami = true;
                    //permisoAlmacen = true;
                    //permisoInicio = true;
                    break;
                case "Seguridad":
                    permisoInicio = true;
                    break;
                case "Administrador":
                    permisoCita = true;
                    permisoPaci = true;
                    permisoInicio = true;
                    permisoAnte = true;
                    permisoEmple = true;
                    permisoCami = true;
                    permisoBitacora = true;
                    permisoAlmacen = true;
                    break;
            }
        }




        //Mostrar y ocultar botones
        public void BotonesAMostrar()
        {
        }





        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            BotonesAMostrar();
        }




        //codigo para poder arrastrar la ventana por la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //codigo para poder arrastrar la ventana por la pantalla

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //mover ventana
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private Form formActivo = null;
        private void abrirform(Form formHijo)
        {
            if (formActivo != null)
                formActivo.Close();
            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            PanelGeneral.Controls.Add(formHijo);
            PanelGeneral.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }



        public void mostrarPaneles(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocultarPaneles();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        public void ocultarPaneles()
        {
           
        }



        //Hora y fecha inicio
        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToString("hh:mm:ss");
            fecha.Text = DateTime.Now.ToLongDateString();
        }




        //Cerrar Aplicacion
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Maximizar
        private void pictureBox4_Click(object sender, EventArgs e)
        {           
            if (this.WindowState == FormWindowState.Normal) {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        //Minimizar
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }






        //botones Ventana Principal
        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (permisoInicio == false)
            {
                MessageBox.Show("No tiene permiso");
            }
            else
            {
                abrirform(new MenuInicioDoctor());
                ocultarPaneles();
            }
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            if (permisoCita == false)
            {
                MessageBox.Show("No tiene permiso");
            }
            else
            {
                abrirform(new citas());
                ocultarPaneles();
            }
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            if (permisoPaci == false)
            {
                MessageBox.Show("No tiene permiso");
            }
            else
            {
                abrirform(new Paciente());
                ocultarPaneles();
            }
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            if (permisoEmple == false)
            {
                MessageBox.Show("No tiene permiso");
            }
            else
            {
                abrirform(new Empleados());
                ocultarPaneles();
            }
        }

        private void btnLugares_Click(object sender, EventArgs e)
        {
            if (permisoCami == false)
            {
                MessageBox.Show("No tiene permiso");
            }
            else
            {
                abrirform(new Lugares());
                ocultarPaneles();
            }
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            if (permisoAlmacen == false)
            {
                MessageBox.Show("No tiene permiso");
            }
            else
            {
                abrirform(new aux());
                ocultarPaneles();
            }
        }

        private void btnAntecedentes_Click(object sender, EventArgs e)
        {
            if (permisoBitacora == false)
            {
                MessageBox.Show("No tiene permiso");
            }
            else
            {
                abrirform(new Antecedentes());
                ocultarPaneles();
            }
        }

        private void panelHora_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }
    }

}
