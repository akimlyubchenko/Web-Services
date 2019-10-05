using System.Collections.Generic;
using LampService.Model;

namespace LampService
{
	public class Lamp : ILamp
	{
		public List<Model.Lamp> GetAll()
		{
			return new List<Model.Lamp> {
				new Model.Lamp
				{
					Name = "lamp #1",
					Description = "Best Lamp",
					Price = 123.99,
					LightBulb = new LightBulb
					{
						Name = "light bulb #1",
						LightBulbTint = LightBulbTint.Light
					}
				}
			};
		}
	}
}
