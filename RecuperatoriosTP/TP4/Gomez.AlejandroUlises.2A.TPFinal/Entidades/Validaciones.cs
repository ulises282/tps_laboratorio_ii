using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Entidades
{
    public class Validaciones
    {
        public static bool ValidarDni(string dni)
        {
            bool retorno = true;
            if (dni.Length != 8)
            {
                retorno = false;
            }

            bool numeroValido = int.TryParse(dni, out int dniInteger);
            if (!numeroValido)
            {
                retorno = false;
            }

            return retorno;
        }

        public static bool ValidarNombre(string cadena)
        {
            bool retorno = false;
            Regex validacion = new Regex(@"^[a-zA-Z]+$");

            if (validacion.IsMatch(cadena))
            {
                retorno = true;
            }
            return retorno;
        }

    }
}
