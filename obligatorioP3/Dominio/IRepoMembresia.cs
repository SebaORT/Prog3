using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
	public interface IRepoMembresia : IRepositorio<Membresia>
	{
		// List<Producto> ProductosEnRangoDePrecio(decimal desde, decimal hasta);
		DataTable ListarDataTable();
        List<Membresia> ListarPorSocioId(int idSocio);
        bool ModificarFechaPagoHoy(Membresia m);
    }
}
