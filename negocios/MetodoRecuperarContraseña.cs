using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talent.datos;

namespace Talent.negocios
{
    class MetodoRecuperarContraseña
    {
        public string metodo(string userRequesting)
        {
            MySqlDataReader sqldr = null;
            using (var connection = conexionBD.conectar)
            {
                conexionBD.abrir();
                using (var comando = new MySqlCommand())
                {
                    comando.Connection = conexionBD.conectar;
                    comando.CommandText = "select nombre, ape_pat, correo, contra_usuario from usuarios where correo = @txtCorreo";
                    comando.Parameters.AddWithValue("@txtCorreo", userRequesting);
                    comando.CommandType = CommandType.Text;
                    sqldr = comando.ExecuteReader();

                    if (sqldr.Read() == true)
                    {
                        string nombreRecuperado = sqldr.GetString(0);
                        string apellidoRecuperado = sqldr.GetString(1);
                        string contraseñaRecuperado = sqldr.GetString(3);
                        string correoRecuperado = sqldr.GetString(2);

                        var mailService = new SystemSupportMail();
                        mailService.enviarMail(
                            asunto: "RECUPERACIÓN DE CONTRASEÑA",
                                                cuerpo: "Querido usuario " + apellidoRecuperado + " " + nombreRecuperado + "\n" +
                                                "¡Recibimos la solicitud para cambiar la contraseña de tu cuenta Hemodialisis " + "\n"
                                                + "le hacemos entrega por medio de este correo su contraseña: " + contraseñaRecuperado + "\n",
                                                correodestinatario: new List<string> { correoRecuperado
                    }
                                                );
                        return "Hemos enviado un correo con la nueva contraseña " + nombreRecuperado + " espero hayamos podido ser de ayuda";

                    }
                    else
                    {
                        return "No pudimos haber encontrado este correo ";
                    }
                }
            }
        }
    }
}


