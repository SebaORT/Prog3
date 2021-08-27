using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public interface IRepositorioProductos : IRepositorio<Producto>
    {
        List<Producto> ProductosEnRangoDePrecio(decimal desde, decimal hasta);
    }
}
