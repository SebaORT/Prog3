using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Repositorios
{
	public class RepoActividad : IRepoActividad
	{
		private const string TABLE_NAME = "Actividad";


		public bool Alta(Actividad t)
		{
			throw new NotImplementedException();
		}

		public bool Baja(int id)
		{
			throw new NotImplementedException();
		}

		public Actividad Buscar(int id)
		{
			var actividad = new Actividad();

			var connStr=SQLADOHelper.GetConnectionString();
			using (var connection = new SqlConnection(connStr))
			{
				try
				{
					connection.Open();
					var command = SQLADOHelper.GetByIdSQLCommand(connection, TABLE_NAME, id);
					SqlDataReader reader = command.ExecuteReader();


					reader.Read();

					actividad.EdadMax = reader.GetInt32(reader.GetOrdinal("Maxedad"));
					actividad.EdadMin = reader.GetInt32(reader.GetOrdinal("Minedad"));
					actividad.Cupos = reader.GetInt32(reader.GetOrdinal("Cupos"));
					actividad.Nombre = reader.GetString(reader.GetOrdinal("Nombre"));
					
				}
				catch (Exception ex)
				{

				}
				finally
				{
					connection.Close();
				}

				return actividad;
			}


		}

		public List<Actividad> Listar()
		{
			throw new NotImplementedException();
		}

		public bool Modificacion(Actividad t)
		{
			throw new NotImplementedException();
		}
	}
}
