﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Socio
    {
        public string NombreApellido { get; set; }
        public string Cedula { get; set; } //Se le agrega número de socio? Ci dato único 
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaIngreso { get; set; }

    }
}
