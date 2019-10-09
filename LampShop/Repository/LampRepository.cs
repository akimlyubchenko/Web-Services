using System.Linq;
using Repository.Contexts;
using RepositoryInterface;
using RepositoryInterface.Models;

namespace Repository
{
	public class LampRepository : ILampRepository
	{
		private readonly LampDBContext _lampDbContext;

		public LampRepository(LampDBContext lampDBContext)
		{
			_lampDbContext = lampDBContext;
		}

		public Lamp[] GetAll()
		{
			return _lampDbContext.Lamps.ToArray();
		}
	}
}
