using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Talent.datos;

namespace Talent.Dominio
{
    class MetodosLogin
    {
        public int Login(String Usuario, String Contraseña)
        {
                string cadena = "exec spLogin " + Usuario + ", " + Contraseña + ";"; //recibe los string del metodo y lo concatena en la instruccion.
                conexionBD.abrir();
                return conexionBD.lectura(cadena);
                conexionBD.cerrar();
        }
    }
}
