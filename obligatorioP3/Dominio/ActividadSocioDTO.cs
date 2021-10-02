using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
	// Use a data contract as illustrated in the sample below to add composite types to service operations.
	[DataContract]
	public class ActividadSocioDTO
	{

		[DataMember]
		public int IdSocio
		{
			get;
			set;
		}

		[DataMember]
		public int IdActividad
		{
			get;
			set;
		}


		[DataMember]
		public DateTime Fecha { get; set; }
	}

	[DataContract]
	public class ActividadSocioDTOResult
	{
		[DataMember]
		public bool Success { get; set; }

		[DataMember]

		public string Error { get; set; }
	}
}
