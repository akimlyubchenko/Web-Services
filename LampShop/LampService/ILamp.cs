using System.Collections.Generic;
using System.ServiceModel;

namespace LampService
{
	[ServiceContract(Namespace = "LampService")]
	public interface ILamp
	{
		[OperationContract]
		List<Model.Lamp> GetAll();
	}
}
