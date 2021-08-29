using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Datos
{
    public class RepoProductos : IRepositorioProductos
    {
        public bool Alta(Producto t)
        {
            throw new NotImplementedException();
        }

        public bool Baja(int id)
        {
            throw new NotImplementedException();
        }

        public Producto Buscar(int id)
        {
            //ACÁ ESTARÁ LA LÓGIA DE ACCESO A DATOS PARA IR A BUSCAR EL PRODUCTO A LA BD
            return new Producto() { Id = id, Nombre = "El Producto", Precio = 150 };
        }

        public bool Modificacion(Producto t)
        {
            throw new NotImplementedException();
        }

        public List<Producto> TraerTodo()
        {
            throw new NotImplementedException();
        }

        public List<Producto> ProductosEnRangoDePrecio(decimal desde, decimal hasta)
        {
            throw new NotImplementedException();
        }
    }
}
