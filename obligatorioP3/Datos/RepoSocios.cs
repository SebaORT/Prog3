﻿using System;
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
			var connStr = SQLADOHelper.GetConnectionString();

			var result = new List<Socio>();

			using(var connection = new SqlConnection(connStr))
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
						socio.Cedula = reader.GetString(reader.GetOrdinal("Cedula"));
						socio.FechaNacimiento = reader.GetDateTime(reader.GetOrdinal("FechaNacimiento"));
						socio.FechaIngreso = reader.GetDateTime(reader.GetOrdinal("FechaIngreso"));
						socio.Activo = reader.GetBoolean(reader.GetOrdinal("Active"));

						result.Add(socio);
					}

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

		public bool Modificacion(Socio t)
		{
			var result = false;

			var query = "UPDATE [dbo].[Socio] SET[Cedula] = @ci, [FechaNacimiento] = @fnacimiento, [FechaIngreso] = @fingreso, [Active] = @active WHERE IdSocio = @id";

			var connStr = SQLADOHelper.GetConnectionString();

			using(var connection = new SqlConnection())
            {
                try
                {
					connection.Open();
					var command = new SqlCommand(query, connection);
					//faltaría agregar parametro de nombre en caso que se agregue a la tabla
					command.Parameters.AddWithValue("@ci", t.Cedula);
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