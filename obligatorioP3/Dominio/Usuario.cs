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

        public static bool validarDatosUsuario(Usuario usuario)
        {
            //contraseña de al menos 6 caracteres
            //que incluyan letras mayúsculas y minúsculas (al menos una de cada una)
            //dígitos (0 al 9)
            if (usuario.Password.Length >= 6)
            {
                if (usuario.Password.Any(char.IsUpper) && usuario.Password.Any(char.IsLower) && usuario.Password.Any(char.IsDigit))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
