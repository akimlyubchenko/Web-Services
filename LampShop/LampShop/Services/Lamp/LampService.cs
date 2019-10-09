using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LampShop.Services.Lamp
{
	using LampShop.LampService;

	public class LampService
	{
		public RepositoryInterface.Models.Lamp[] GetAllLamps()
		{
			var client = new LampClient();

			var a = client.GetAll();

			client.Close();

			return a;
		}
	}
}