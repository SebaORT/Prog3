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

			var connStr=SQLADOHelper.GetConnectionString("sa", "<<psw>>", "localhost\\SQLEXPRESS");
			using (var connection = new SqlConnection(connStr))
			{
				try
				{
					connection.Open();
					var command = SQLADOHelper.GetByIdSQLCommand(connection, TABLE_NAME, id);
					SqlDataReader reader = command.ExecuteReader();


					//actividad.Cupos = reader.get
					
					actividad.EdadMax = reader.GetInt32(reader.GetOrdinal("Maxedad"));

					///
					///
					///
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
