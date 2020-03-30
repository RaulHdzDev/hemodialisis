using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;


namespace Talent.datos
{

    class conexionBD
    {
        public static MySqlConnection conectar { get; set; }

        public static void abrir()
        {
            try
            {
                MySqlConnectionStringBuilder stringBuilder = new MySqlConnectionStringBuilder();
                stringBuilder.Server = Talent.Properties.Settings.Default.server;
                stringBuilder.Database = Talent.Properties.Settings.Default.Database;
                stringBuilder.UserID = Talent.Properties.Settings.Default.user;
                stringBuilder.Password = Talent.Properties.Settings.Default.password;

                conectar = new MySqlConnection(stringBuilder.ConnectionString);

                conectar.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        public static int lectura(String cadena)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand(cadena, conectar);
                MySqlDataReader lector = comando.ExecuteReader();
                //SqlDataReader registro = comando.ExecuteReader();
                if (lector.Read())
                    return 1; //MessageBox.Show("Login exitoso!");
                else
                    return 2; //MessageBox.Show("Credenciales incorrectas");
            }
            catch (Exception ex)
            {
                return 3; //MessageBox.Show("Hay un error");
            }
        }

        public static void cerrar()
        {
            conectar.Close();
        }



    }
}
