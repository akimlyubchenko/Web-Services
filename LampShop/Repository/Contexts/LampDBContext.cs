using System;
using System.Collections.Generic;
using System.Data.Entity;
using RepositoryInterface.Models;

namespace Repository.Contexts
{
	public class LampDBContext : DbContext
	{
		public LampDBContext() : base("name=LampConnection")
		{
			Database.SetInitializer<LampDBContext>(new LampDBInitializer());
		}

		public DbSet<Lamp> Lamps { get; set; }
	}

	public class LampDBInitializer : CreateDatabaseIfNotExists<LampDBContext>
	{
		protected override void Seed(LampDBContext dbContext)
		{
			var lamps = new List<Lamp>();
			var enumValues = Enum.GetValues(typeof(LightBulbTint));
			Random random = new Random();

			for (int i = 1; i < 6; i++)
			{
				lamps.Add(new Lamp
				{
					Name = $"lamp #{i}",
					Description = "The best lamp",
					Price = i * 121,
					LightBulb = new LightBulb
					{
						Name = $"Light bulb #{i}",
						LightBulbTint = (LightBulbTint)enumValues.GetValue(random.Next(enumValues.Length))
					}
				});
			}

			dbContext.Lamps.AddRange(lamps);
			dbContext.SaveChanges();
			base.Seed(dbContext);
		}
	}
}
