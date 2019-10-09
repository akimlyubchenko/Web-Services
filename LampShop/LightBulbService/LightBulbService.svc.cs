using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LightBulbService
{
	public class LightBulbService : ILightBulbService
	{
		public string GetLightBulb(int value)
		{
			return string.Format("You entered: {0}", value);
		}
	}
}
