using System.Collections.Generic;
using System.ServiceModel;

namespace LampService
{
	[ServiceContract]
	public interface ILamp
	{
		[OperationContract]
		List<Model.Lamp> GetAll();
	}
}
