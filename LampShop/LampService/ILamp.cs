using System.Collections.Generic;
using System.ServiceModel;
using LampModel = RepositoryInterface.Models.Lamp;

namespace LampService
{
	[ServiceContract(Namespace = "LampService")]
	public interface ILamp
	{
		[OperationContract]
		LampModel[] GetAll();
	}
}
