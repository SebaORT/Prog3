using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for ActividadSocioDTO
/// </summary>
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