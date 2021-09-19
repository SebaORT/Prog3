using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios
{
	public static class SQLADOHelper
	{
		public static string GetConnectionString(string userid = "sa",
			string psw = "ah!9(xNbonq-hLk4Gm;Ez(dEe-RvB.tJ",
			string server = ".\\SQLEXPRESS", string database = "ObligatorioP3_GestionClub")
		{
			SqlConnectionStringBuilder builder =
			new SqlConnectionStringBuilder();

			builder.UserID = userid;
			builder.Password = psw;

			builder.AsynchronousProcessing = true;


			builder["Database"] = database;
			builder["Server"] = server;
			builder["Connect Timeout"] = 1000;
			builder["Trusted_Connection"] = true;
			return builder.ConnectionString;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="connection"></param>
		/// <param name="table">activididad, membresia, usuario, socios</param>
		/// <param name="id"></param>
		/// <returns></returns>
		public static SqlCommand GetByIdSQLCommand(SqlConnection connection, string table, int id)
		{
			var command = new SqlCommand($"select * from {table} where Id = @Id", connection);
			command.Parameters.AddWithValue("@Id", id);

			return command;
		}

		public static SqlCommand ListarSQLCommand(SqlConnection connection, string table)
		{
			var command = new SqlCommand($"select * from {table}", connection);

			return command;
		}

		
		/* GOOD TO HAVE, BUT NO ES NECESARIO
		public static SqlCommand ModificacionSQLCommand(SqlConnection connection, string table, List<Tuple<string,object>> values )
		{

			var command = new SqlCommand($"update {table} set column = <<object>> from {table}", connection);

			return command;
		}


		public static SqlCommand AltaSQLCommand(SqlConnection connection, string table)
		{
			var command = new SqlCommand($"insert into {table} values ....  from {table}", connection);

			return command;
		}
		*/

		public static SqlCommand BajaSQLCommand(SqlConnection connection, string table, bool active)
		{
			var command = new SqlCommand($"update {table} set Active=@active" , connection);
			command.Parameters.AddWithValue("@active", active);
			return command;
		}


	}

}
