using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }

        public bool validarDatosUsuario()
        {
            //contraseña de al menos 6 caracteres
            //que incluyan letras mayúsculas y minúsculas (al menos una de cada una)
            //dígitos (0 al 9)
            if (Password.Length >= 6)
            {
                if (Password.Any(char.IsUpper) && Password.Any(char.IsLower) && Password.Any(char.IsDigit))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
