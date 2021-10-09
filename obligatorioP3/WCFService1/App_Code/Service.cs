using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Dominio;
using Repositorios;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
	IRepoActividad repoActividad = new RepoActividad();
	IRepoSocios repoSocios = new RepoSocios();

	public string GetData(int value)
	{
		return string.Format("You entered: {0}", value);
	}

	public ActividadSocioDTOResult IngresarSocioActividad(ActividadSocioDTO actividadSocio)
	{
		if (actividadSocio == null)
		{
			return new ActividadSocioDTOResult
			{
				Success = false,
				Error = "Parametros invalidos al tratar ingresar un socio en una actividad"
			};
		}


		if (repoSocios.Buscar(actividadSocio.IdSocio) == null)
		{
			return new ActividadSocioDTOResult
			{
				Success = false,
				Error = "Socio al dar de alta actividad debe existir"
			};
		}

		if (repoActividad.Buscar(actividadSocio.IdActividad) == null)
		{
			return new ActividadSocioDTOResult
			{
				Success = false,
				Error = "Socio al dar de alta actividad debe existir"
			};
		}


		try
		{
			int resultIngresoSocioActividad = repoSocios.IngresarActividadSocio(actividadSocio.IdSocio, actividadSocio.IdActividad, actividadSocio.Fecha);

			if (resultIngresoSocioActividad	> 0)
			{
				return new ActividadSocioDTOResult
				{
					Success = true,
					Error = ""
				};
			}
			else
			{
				return new ActividadSocioDTOResult
				{
					Success = false,
					Error = "No se pudo ingresar el socio en la actividad result: " + resultIngresoSocioActividad
				};
			}
		}
		catch (Exception ex)
		{
			return new ActividadSocioDTOResult
			{
				Success = false,
				Error = ex.Message + "-" + (ex.InnerException != null ? ex.InnerException.Message : "")
			};
		}
	}
}
