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
	public class RepoConfig : IRepoConfig
	{
		private const string TABLE_NAME = "Configuration";


		public int Alta(Configuration t)
		{
			return -1;

		}

		public bool Baja(int id)
		{
			return true;

		}

		public Configuration Buscar(int id)
		{
			var connStr=SQLADOHelper.GetConnectionString();
			Configuration config;
			using (var connection = new SqlConnection(connStr))
			{
				try
				{
					connection.Open();
					var command = SQLADOHelper.GetByIdSQLCommand(connection, TABLE_NAME, id);
					SqlDataReader reader = command.ExecuteReader();


					reader.Read();
					config=GetConfigFromReader(reader);

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
			return config;

		}

		private static Configuration GetConfigFromReader(SqlDataReader reader)
		{
			Configuration config = new Configuration();

			var antigStr = reader.GetString(reader.GetOrdinal("AntiguedadEstablecida"));
			var cantActivDescuentoStr = reader.GetString(reader.GetOrdinal("CantActividadesDescuento"));
			var descCuponeraStr = reader.GetString(reader.GetOrdinal("DescuentoCuponera"));
			var costoFijoStr = reader.GetString(reader.GetOrdinal("CostoFijo"));
			var descPaseLibreStr = reader.GetString(reader.GetOrdinal("DescuentoPaseLibre"));
			var montoUnitarioCuponera = reader.GetString(reader.GetOrdinal("MontoUnitarioCuponera"));

			int aux;
			config.AntiguedadEstablecida = !int.TryParse(antigStr, out aux) ? 1 : aux;
			config.CantActividadesDescuento = !int.TryParse(cantActivDescuentoStr, out aux) ? 0 : aux;

			double auxD;
			config.DescuentoCuponera =!double.TryParse(descCuponeraStr, out auxD) ? 0 : auxD;
			config.CostoFijo = !double.TryParse(costoFijoStr, out auxD) ? 0 : auxD;
			config.DescuentoPaseLibre =!double.TryParse(descPaseLibreStr, out auxD) ? 0 : auxD;

			config.MontoUnitarioCuponera = !double.TryParse(montoUnitarioCuponera, out auxD) ? 0 : auxD;

			return config;
		}

		public DataTable ListarDataTable()
		{
			return SQLADOHelper.GetDataTableUtil(TABLE_NAME);
		}

		public List<Configuration> Listar()
		{
			var connStr = SQLADOHelper.GetConnectionString();

			var result = new List<Configuration>();
			using (var connection = new SqlConnection(connStr))
			{
				try
				{
					connection.Open();
					var command = SQLADOHelper.ListarSQLCommand(connection,TABLE_NAME);
					SqlDataReader reader = command.ExecuteReader();

					while (reader.Read())
					{
						var configuration = GetConfigFromReader(reader);

						result.Add(configuration);
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

		public bool Modificacion(Configuration t)
		{
			return false;
		}
	}
}
