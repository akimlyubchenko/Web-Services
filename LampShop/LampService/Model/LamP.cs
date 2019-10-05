using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LampService.Model
{
	[DataContract]
	public class Lamp
	{
		[DataMember]
		public int Id { get; set; }

		[DataMember]
		public string Name { get; set; }

		[DataMember]
		public double Price { get; set; }

		[DataMember]
		public string Description { get; set; }

		[DataMember]
		public LightBulb LightBulb { get; set; }
	}
}
