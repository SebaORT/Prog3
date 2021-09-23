using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Repositorios
{
	public class RepoSocios : IRepoSocios
	{
		public int Alta(Socio t)
        {
            string query = "INSERT into [dbo].[Socio] (Cedula, FechaNacimiento, FechaIngreso, Active) VALUES (@ci, @fnacimiento, @fingreso, @active";

			var connStr = SQLADOHelper.GetConnectionString();

			int result = -1;

			using (var connection = new SqlConnection(connStr))
            {
                try
                {
					connection.Open();
					var command = new SqlCommand(query, connection);
					command.Parameters.AddWithValue("@ci", t.Cedula);
					command.Parameters.AddWithValue("@fnacimiento", t.FechaNacimiento);
					command.Parameters.AddWithValue("@fingreso", t.FechaIngreso);
					command.Parameters.AddWithValue("@active", t.Activo);

					object val = command.ExecuteScalar();

					result = val != null ? Convert.ToInt32(val) : -1;

				}
				catch(Exception ex) 
                {
					throw ex;
                }
                finally
                {
					connection.Close();
                }

            }

			return result;
		}

        public bool Baja(int id)
		{
			var connStr = SQLADOHelper.GetConnectionString();

			bool result = false;

			using (var connection = new SqlConnection(connStr))
			{
				try
				{
					connection.Open();
					var command = SQLADOHelper.BajaSQLCommand(connection, "Socio", false, id);
					int res = command.ExecuteNonQuery();

					result = res >= 0 ? true : false;
				}
				catch (Exception ex)
				{
					throw ex;
				}
				finally
				{
					connection.Close();
				}
			}


			return result;

		}

		public Socio Buscar(int id)
		{
			var connStr = SQLADOHelper.GetConnectionString();
			var socio = new Socio();
			using (var connection = new SqlConnection(connStr))
			{
				try
				{
					connection.Open();
					var command = SQLADOHelper.GetByIdSQLCommand(connection, "Socio", id);
					SqlDataReader reader = command.ExecuteReader();


					reader.Read();

					socio.IdSocio = reader.GetInt32(reader.GetOrdinal("IdSocio"));
					socio.Cedula = reader.GetString(reader.GetOrdinal("Cedula"));
					socio.FechaNacimiento = reader.GetDateTime(reader.GetOrdinal("FechaNacimiento"));
					socio.FechaIngreso = reader.GetDateTime(reader.GetOrdinal("Fechaingreso"));
					socio.FechaNacimiento = reader.GetDateTime(reader.GetOrdinal("FechaNacimiento"));
					socio.Activo = reader.GetBoolean(reader.GetOrdinal("Active"));


				}
				catch (Exception ex)
				{
					throw ex;
				}
				finally
				{
					connection.Close();
				}
			}
			return socio;

		}

		public List<Socio> Listar()
		{
			throw new NotImplementedException();
		}

		public bool Modificacion(Socio t)
		{
			throw new NotImplementedException();
		}
	}
}
