using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{

	[OperationContract]
	string GetData(int value);

	[OperationContract]
	CompositeType GetDataUsingDataContract(CompositeType composite);


	[OperationContract]
	ActividadSocioDTOResult IngresarSocioActividad(ActividadSocioDTO composite);

	// TODO: Add your service operations here
}

// Use a data contract as illustrated in the sample below to add composite types to service operations.
[DataContract]
public class CompositeType
{
	bool boolValue = true;
	string stringValue = "Hello ";

	[DataMember]
	public bool BoolValue
	{
		get { return boolValue; }
		set { boolValue = value; }
	}

	[DataMember]
	public string StringValue
	{
		get { return stringValue; }
		set { stringValue = value; }
	}
}


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

