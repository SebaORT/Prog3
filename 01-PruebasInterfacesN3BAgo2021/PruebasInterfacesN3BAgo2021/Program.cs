using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Datos;

namespace PruebasInterfacesN3BAgo2021
{
    class Program
    {
        static void Main(string[] args)
        {            
            RepositorioTelevisores repoTvs = new RepositorioTelevisores();
            Televisor t = repoTvs.Buscar(5);        
        }
    }
}
