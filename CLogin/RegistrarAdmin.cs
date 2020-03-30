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
namespace Talent
{
    public partial class RegistrarAdmin : Form
    {
        public RegistrarAdmin()
        {
            InitializeComponent();
        }



        //codigo para poder arrastrar la ventana por la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //codigo para poder arrastrar la ventana por la pantalla




        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegistrarAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnLIniciarSesion_Click(object sender, EventArgs e)
        {
            Form regresarlogin = new Login();
            this.Hide();
            regresarlogin.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login abrirLogin = new Login();
            abrirLogin.Show();
        }

        private void btnLIniciarSesion_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login abrirLogin = new Login();
            abrirLogin.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
