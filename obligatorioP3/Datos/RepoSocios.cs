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

        //TODO
        //public IngresosFechaData

		public int IngresarActividadSocio(int idSocio, int idActividad, DateTime dateTime)
		{

			var sql = @"INSERT INTO[dbo].[SocioActividad]
			([IdSocio]
		  ,[IdActividad]
		  ,[Fecha])

	 VALUES
		   (@idSocio
		   ,@idActividad
		   ,@date)";

			int result = -1;
			using (var connection = new SqlConnection(SQLADOHelper.GetConnectionString()))
			{
				try
				{
					connection.Open();
					var command = new SqlCommand(sql, connection);
					command.Parameters.AddWithValue("@idSocio", idSocio);
					command.Parameters.AddWithValue("@idActividad", idActividad);
					command.Parameters.AddWithValue("@date", dateTime);

					object val = command.ExecuteNonQuery();

					result = val != null ? Convert.ToInt32(val) : -1;

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


		public int Alta(Socio t)
        {
            string query = @"INSERT into [dbo].[Socio] (Cedula, NombreApellido, FechaNacimiento, FechaIngreso, Active) 
VALUES (@ci, @nomApellido, @fnacimiento, @fingreso, @active);
select SCOPE_IDENTITY() from [dbo].[Socio]";

            var connStr = SQLADOHelper.GetConnectionString();

			int result = -1;
			using (var connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    var command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ci", t.Cedula);
                    command.Parameters.AddWithValue("@nomApellido", t.NombreApellido);
                    command.Parameters.AddWithValue("@fnacimiento", t.FechaNacimiento);
                    command.Parameters.AddWithValue("@fingreso", t.FechaIngreso);
                    command.Parameters.AddWithValue("@active", t.Activo);

                    object val = command.ExecuteScalar();

                    result = val != null ? Convert.ToInt32(val) : -1;

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
                    var command = new SqlCommand("Update Socio set Active=@active where idSocio = @id", connection);
                    command.Parameters.AddWithValue("@active", false);
                    command.Parameters.AddWithValue("@id", id);
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
            Socio socio = null;
            using (var connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    var command = SQLADOHelper.GetByParamSQLCommand(connection, "Socio", "IdSocio", id);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        socio = new Socio();

                        socio.IdSocio = reader.GetInt32(reader.GetOrdinal("IdSocio"));
                        socio.NombreApellido = reader.GetString(reader.GetOrdinal("NombreApellido"));
                        socio.Cedula = reader.GetDecimal(reader.GetOrdinal("Cedula"));
                        socio.FechaNacimiento = reader.GetDateTime(reader.GetOrdinal("FechaNacimiento"));
                        socio.FechaIngreso = reader.GetDateTime(reader.GetOrdinal("Fechaingreso"));
                        socio.FechaNacimiento = reader.GetDateTime(reader.GetOrdinal("FechaNacimiento"));
                        socio.Activo = reader.GetBoolean(reader.GetOrdinal("Active"));

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
            return socio;

        }

        public Socio BuscarPorCedula(decimal cedulaSocio)
        {
            var connStr = SQLADOHelper.GetConnectionString();
            Socio socio = null;
            using (var connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    var command = SQLADOHelper.GetByParamSQLCommand(connection, "Socio", "Cedula", cedulaSocio);
                    SqlDataReader reader = command.ExecuteReader();


                    while (reader.Read())
                    {
                        socio = new Socio();

                        socio.IdSocio = reader.GetInt32(reader.GetOrdinal("IdSocio"));
                        socio.NombreApellido = reader.GetString(reader.GetOrdinal("NombreApellido"));
                        socio.Cedula = reader.GetDecimal(reader.GetOrdinal("Cedula"));
                        socio.FechaNacimiento = reader.GetDateTime(reader.GetOrdinal("FechaNacimiento"));
                        socio.FechaIngreso = reader.GetDateTime(reader.GetOrdinal("Fechaingreso"));
                        socio.FechaNacimiento = reader.GetDateTime(reader.GetOrdinal("FechaNacimiento"));
                        socio.Activo = reader.GetBoolean(reader.GetOrdinal("Active"));

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
            return socio;
        }

        public List<Socio> Listar()
        {
            var connStr = SQLADOHelper.GetConnectionString();

            var result = new List<Socio>();

            using (var connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();

                    var command = SQLADOHelper.ListarSQLCommand(connection, "Socio");

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var socio = new Socio();
                        //socio.NombreApellido = reader.GetString(reader.GetOrdinal("Nombre")); revisar tabla socio hay que agregar parametro NombreApellido
                        socio.IdSocio = reader.GetInt32(reader.GetOrdinal("IdSocio"));
                        socio.NombreApellido = reader.GetString(reader.GetOrdinal("NombreApellido"));
                        socio.Cedula = reader.GetDecimal(reader.GetOrdinal("Cedula"));
                        socio.FechaNacimiento = reader.GetDateTime(reader.GetOrdinal("FechaNacimiento"));
                        socio.FechaIngreso = reader.GetDateTime(reader.GetOrdinal("FechaIngreso"));
                        socio.Activo = reader.GetBoolean(reader.GetOrdinal("Active"));

                        result.Add(socio);
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

        public bool Modificacion(Socio t)
        {
            var result = false;

            var query = "UPDATE [dbo].[Socio] SET [Cedula] = @ci, NombreApellido = @nombre, [FechaNacimiento] = @fnacimiento, [FechaIngreso] = @fingreso, [Active] = @active WHERE IdSocio = @id";

            var connStr = SQLADOHelper.GetConnectionString();

            using (var connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    var command = new SqlCommand(query, connection);
                    //faltaría agregar parametro de nombre en caso que se agregue a la tabla
                    command.Parameters.AddWithValue("@ci", t.Cedula);
                    command.Parameters.AddWithValue("@nombre", t.NombreApellido);

                    command.Parameters.AddWithValue("@fnacimiento", t.FechaNacimiento);
                    command.Parameters.AddWithValue("@fingreso", t.FechaIngreso);
                    command.Parameters.AddWithValue("@active", t.Activo);
                    command.Parameters.AddWithValue("@Id", t.IdSocio);

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


/**UPDATE [dbo].[Socio]
SET[Cedula] = < Cedula, numeric(10, 0),>
      ,[FechaNacimiento] = < FechaNacimiento, datetime,>
      ,[FechaIngreso] = < FechaIngreso, datetime,>
      ,[Active] = < Active, bit,>
  WHERE IdSocio = @id**/