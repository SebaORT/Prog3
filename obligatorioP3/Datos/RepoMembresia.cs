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
    public class RepoMembresia : IRepoMembresia
    {
        private const string TABLE_NAME = "Membresia";


        public int Alta(Membresia t)
        {
            string query = @"INSERT INTO [dbo].[Membresia]
           ([Nombre]
           ,[Description]
           ,[Fechapago]
           ,[Active]
           ,[CantActividades]
           ,[Tipomembresia])
			 VALUES
				   (@nombre
				   ,@descripcion
				   ,@fechaPago
				   ,@active
				   ,@cantActividades
				   ,@tipoMembresia);
		select SCOPE_IDENTITY() from [dbo].[Membresia]
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
                    command.Parameters.AddWithValue("@descripcion", t.Descipcion);
                    command.Parameters.AddWithValue("@fechaPago", t.FechaPago);
                    command.Parameters.AddWithValue("@active", t.Active);
                    if(t.TipoMembresia == "cuponera")
                    {
                        command.Parameters.AddWithValue("@cantActividades",((Cuponera) t).CantActividades);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@cantActividades", 0);
                    } 
                    
                    command.Parameters.AddWithValue("@tipoMembresia", t.TipoMembresia);


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
                    var command = SQLADOHelper.BajaSQLCommand(connection, TABLE_NAME, false, id);
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

        public Membresia Buscar(int id)
        {
            var connStr = SQLADOHelper.GetConnectionString();
            Membresia membresia = null;
            using (var connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    var command = SQLADOHelper.GetByIdSQLCommand(connection, TABLE_NAME, id);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        if (reader["Tipomembresia"].ToString() == "paselibre") //ES IMPORTADO
                        {
                            membresia = new PaseLibre();
                        }
                        else
                        {
                            membresia = new Cuponera((int)reader["CantActividades"]);
                        }
                        membresia.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                        membresia.Nombre = reader.GetString(reader.GetOrdinal("Nombre"));
                        membresia.Descipcion = reader.GetString(reader.GetOrdinal("Description"));
                        membresia.FechaPago = reader.GetDateTime(reader.GetOrdinal("Fechapago"));
                        membresia.Active = reader.GetBoolean(reader.GetOrdinal("Active"));
                        membresia.TipoMembresia = reader.GetString(reader.GetOrdinal("Tipomembresia"));
                        if (membresia.TipoMembresia == "cuponera")
                        {
                            ((Cuponera) membresia).CantActividades = reader.GetInt32(reader.GetOrdinal("CantActividades"));
                        }                                            
                        
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
            return membresia;
        }

        public List<Membresia> Listar()
        {
            var connStr = SQLADOHelper.GetConnectionString();
            Membresia membresia = null;
            var result = new List<Membresia>();
            using (var connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    var command = SQLADOHelper.ListarSQLCommand(connection, TABLE_NAME);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        if (reader["Tipomembresia"].ToString() == "paselibre") //ES IMPORTADO
                        {
                            membresia = new PaseLibre();
                        }
                        else
                        {
                            membresia = new Cuponera((int)reader["CantActividades"]);
                        }
                        membresia.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                        membresia.Nombre = reader.GetString(reader.GetOrdinal("Nombre"));
                        membresia.Descipcion = reader.GetString(reader.GetOrdinal("Description"));
                        var index = reader.GetOrdinal("Fechapago");                        
                        membresia.FechaPago = reader.IsDBNull(index) ?
                          (DateTime?)null :
                          (DateTime?)reader.GetDateTime(index);                        
                        membresia.Active = reader.GetBoolean(reader.GetOrdinal("Active"));
                        membresia.TipoMembresia = reader.GetString(reader.GetOrdinal("Tipomembresia"));
                        if (membresia.TipoMembresia == "cuponera")
                        {
                            ((Cuponera)membresia).CantActividades = reader.GetInt32(reader.GetOrdinal("CantActividades"));
                        }
                        result.Add(membresia);
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
            var connStr = SQLADOHelper.GetConnectionString();

            var result = new DataTable();
            using (var connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    var command = SQLADOHelper.ListarSQLCommand(connection, TABLE_NAME);
                    SqlDataReader reader = command.ExecuteReader();

                    result.Load(reader);

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

        public bool Modificacion(Membresia t)
        {
            string query_update = @"UPDATE [dbo].[Membresia]
   SET [Nombre] = @nombre
      ,[Description] = @description
      ,[Fechapago] = @fechapago
      ,[Active] = @active
      ,[CantActividades] = @cantActividades
      ,[Tipomembresia] = @tipoMembresia
 WHERE Id = @Id";

            var connStr = SQLADOHelper.GetConnectionString();
            bool result = false;

            using (var connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    var command = new SqlCommand(query_update, connection);
                    command.Parameters.AddWithValue("@nombre", t.Nombre);
                    command.Parameters.AddWithValue("@description", t.Descipcion);
                    command.Parameters.AddWithValue("@fechapago", t.FechaPago);
                    command.Parameters.AddWithValue("@active", t.Active);
                    if (t.TipoMembresia == "cuponera")
                    {
                        command.Parameters.AddWithValue("@cantActividades", ((Cuponera)t).CantActividades);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@cantActividades", 0);
                    }                    
                    command.Parameters.AddWithValue("@tipoMembresia", t.TipoMembresia);

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
