using System;
using System.Collections.Generic;
using System.Data;
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


		public int Alta(Actividad t)
		{
			string query = @"INSERT INTO [dbo].[Actividad]
			([Nombre]
			,[Minedad]
			,[Maxedad]
			,[Active]
			,[Cupos])
			 VALUES
				   (@nombre
				   ,@minedad
				   ,@maxedad
				   ,@active
				   ,@cupos);
select SCOPE_IDENTITY() from [dbo].[Actividad]
GO";

			var connStr = SQLADOHelper.GetConnectionString();

			int result = -1;

			using (var connection = new SqlConnection(connStr))
			{
				try
				{
					connection.Open();
					var command = new SqlCommand(query, connection);
					command.Parameters.AddWithValue("@nombre", t.Nombre);
					command.Parameters.AddWithValue("@minedad", t.EdadMin);
					command.Parameters.AddWithValue("@maxedad", t.EdadMax);
					command.Parameters.AddWithValue("@active", t.Active);
					command.Parameters.AddWithValue("@cupos", t.Cupos);

					object val = command.ExecuteScalar();

					result = val!= null ? Convert.ToInt32(val) : -1;

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

		public bool Baja(int id)
		{
			var connStr = SQLADOHelper.GetConnectionString();
			bool result = false;

			using (var connection = new SqlConnection(connStr))
			{
				try
				{
					connection.Open();
					var command = SQLADOHelper.BajaSQLCommand(connection, TABLE_NAME, false,id);
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

		public Actividad Buscar(int id)
		{
			var connStr=SQLADOHelper.GetConnectionString();
			var actividad = new Actividad();
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
					actividad.Active = reader.GetBoolean(reader.GetOrdinal("Active"));
					
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
			return actividad;

		}
		public List<Horario> ListarHorariosActividad( int idActividad)
		{
			var connStr = SQLADOHelper.GetConnectionString();

			var result = new List<Horario>();
			using (var connection = new SqlConnection(connStr))
			{
				try
				{
					connection.Open();
					var command = SQLADOHelper.GetByParamSQLCommand(connection, 
						"ActividadHorario","IdActividad",idActividad);
					SqlDataReader reader = command.ExecuteReader();

					while (reader.Read())
					{
						var horario = new Horario();

						int dayAux = reader.GetInt32(reader.GetOrdinal("Dia"));
						int day = (dayAux == 7) ? 0 : dayAux;

						horario.DiaSemana = (DayOfWeek)day;
						horario.Hora = reader.GetInt32(reader.GetOrdinal("Hora"));

						result.Add(horario);
					}

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
		public List<Actividad> Listar()
		{
			var connStr = SQLADOHelper.GetConnectionString();

			var result = new List<Actividad>();
			using (var connection = new SqlConnection(connStr))
			{
				try
				{
					connection.Open();
					var command = SQLADOHelper.ListarSQLCommand(connection,TABLE_NAME);
					SqlDataReader reader = command.ExecuteReader();

					while (reader.Read())
					{
						var actividad = new Actividad();
						actividad.Id = reader.GetInt32(reader.GetOrdinal("Id"));
						actividad.EdadMax = reader.GetInt32(reader.GetOrdinal("Maxedad"));
						actividad.EdadMin = reader.GetInt32(reader.GetOrdinal("Minedad"));
						actividad.Cupos = reader.GetInt32(reader.GetOrdinal("Cupos"));
						actividad.Nombre = reader.GetString(reader.GetOrdinal("Nombre"));
						actividad.Active = reader.GetBoolean(reader.GetOrdinal("Active"));

						result.Add(actividad);
					}

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

		public DataTable ListarDataTable()
		{
			return SQLADOHelper.GetDataTableUtil(TABLE_NAME);
		}

		public DataTable ListarActividadHorarioDataTable()
		{
			return SQLADOHelper.GetDataTableUtil("Actividadhorario");
		}

		public bool Modificacion(Actividad t)
		{
			string query_update = @"UPDATE [dbo].[Actividad]
   SET [Nombre] = @nombre
      ,[Minedad] = @minedad
      ,[Maxedad] = @maxedad
      ,[Active] = @active
      ,[Cupos] = @cupos
 WHERE Id = @Id";

			var connStr = SQLADOHelper.GetConnectionString();
			bool result = false;

			using (var connection = new SqlConnection(connStr))
			{
				try
				{
					connection.Open();
					var command = new SqlCommand(query_update,connection);
					command.Parameters.AddWithValue("@nombre", t.Nombre);
					command.Parameters.AddWithValue("@minedad", t.EdadMin);
					command.Parameters.AddWithValue("@maxedad", t.EdadMax);
					command.Parameters.AddWithValue("@active", t.Active);
					command.Parameters.AddWithValue("@cupos", t.Cupos);
					command.Parameters.AddWithValue("@Id", t.Id);

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
	}
}
