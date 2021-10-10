using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
	public interface IRepoActividad : IRepositorio<Actividad>
	{
		DataTable ListarDataTable();
		List<Horario> ListarHorariosActividad(int idActividad);
		DataTable ListarActividadHorarioDataTable();

	}
}
