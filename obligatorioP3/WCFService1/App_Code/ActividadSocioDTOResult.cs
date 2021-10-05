using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for ActividadSocioDTOResult
/// </summary>
[DataContract]
public class ActividadSocioDTOResult
{
	[DataMember]
	public bool Success { get; set; }

	[DataMember]
	public string Error { get; set; }
}
