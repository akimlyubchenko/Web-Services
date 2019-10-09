using System.Collections.Generic;
using Repository;
using RepositoryInterface;
using RepositoryInterface.Models;
using LampModel = RepositoryInterface.Models.Lamp;

namespace LampService
{
	public class Lamp : ILamp
	{
		private readonly ILampRepository _lampRepository;

		public Lamp(/*ILampRepository lampRepository*/)
		{
			_lampRepository = new LampRepository(new Repository.Contexts.LampDBContext());
		}

		public LampModel[] GetAll()
		{
			return _lampRepository.GetAll();
		}

		public LampModel Get(int id)
		{
			return new LampModel();
		}
	}
}
