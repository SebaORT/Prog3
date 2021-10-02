﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
	public interface IRepoSocios : IRepositorio<Socio>
	{
		Socio BuscarPorCedula(decimal cedulaSocio);
		int IngresarActividadSocio(int idSocio, int idActividad, DateTime dateTime);

	}
}
