using System.Web.Mvc;

namespace LampShop.Controllers
{
	using System.Diagnostics;
	using LampService;
	using Services.Lamp;

	public class LampController : Controller
	{
		private readonly LampService _lampService;

		public LampController(LampService lampService)
		{
			_lampService = lampService;
		}

		public ActionResult Index()
		{
			var lamps = _lampService.GetAllLamps();
			return View(lamps);
		}
	}
}