using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Repositorios
{
	public class RepoUsuario : IRepoUsuario
	{
		public int Alta(Usuario t)
		{
			string query = "INSERT into[dbo].[Usuario] (IdUsuario, Mail, Password) VALUES(@Id, @Mail, @Password)";
			var connStr = SQLADOHelper.GetConnectionString();

			int result = -1;

			using (var connection = new SqlConnection(connStr))
			{
				try
				{
					connection.Open();
					var command = new SqlCommand(query, connection);
					command.Parameters.AddWithValue("@Id", t.IdUsuario);
					command.Parameters.AddWithValue("@Mail", t.Mail);
					command.Parameters.AddWithValue("@Password", t.Password);


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
					var command = SQLADOHelper.BajaSQLCommand(connection, "Usuario", false, id);
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

		public Usuario Buscar(int id)
		{
			var connStr = SQLADOHelper.GetConnectionString();
			var user = new Usuario();
			using (var connection = new SqlConnection(connStr))
			{
				try
				{
					connection.Open();
					var command = SQLADOHelper.GetByIdSQLCommand(connection, "Usuario", id);
					SqlDataReader reader = command.ExecuteReader();


					reader.Read();

					user.IdUsuario = reader.GetInt32(reader.GetOrdinal("IdSocio"));
					user.Mail = reader.GetString(reader.GetOrdinal("Mail"));
					user.Password = reader.GetString(reader.GetOrdinal("Password"));



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
			return user;
		}

		public List<Usuario> Listar()
		{
			var connStr = SQLADOHelper.GetConnectionString();

			var result = new List<Usuario>();

			using (var connection = new SqlConnection(connStr))
			{
				try
				{
					connection.Open();

					var command = SQLADOHelper.ListarSQLCommand(connection, "Usuario");

					SqlDataReader reader = command.ExecuteReader();
					while (reader.Read())
					{
						var user = new Usuario();
						
						user.IdUsuario = reader.GetInt32(reader.GetOrdinal("IdUsuario"));
						user.Mail = reader.GetString(reader.GetOrdinal("Mail"));
						user.Password = reader.GetString(reader.GetOrdinal("Password"));

						result.Add(user);
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

		public bool Modificacion(Usuario t)
		{
			var result = false;

			var query = "UPDATE [dbo].[Usuario] SET[Password] = @Password, [Mail] = @mail WHERE IdSocio = @id";

			var connStr = SQLADOHelper.GetConnectionString();

			using (var connection = new SqlConnection())
			{
				try
				{
					connection.Open();
					var command = new SqlCommand(query, connection);			
					command.Parameters.AddWithValue("@Password", t.Password);
					command.Parameters.AddWithValue("@Mail", t.Mail);

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
