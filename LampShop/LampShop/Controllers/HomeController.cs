using System.Web.Mvc;

namespace LampShop.Controllers
{
	using System.Diagnostics;
	using LampService;

	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			var client = new LampClient();
			
			var a = client.GetAll();
			Debug.Write(a);
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}