using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace LampShop
{
	using App_Start;
	using Autofac;
	using Autofac.Integration.Mvc;

	public class MvcApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			SetResolver();

			AreaRegistration.RegisterAllAreas();
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);
		}

		private void SetResolver()
		{
			var builder = new ContainerBuilder();
			AutofacConfig.ConfigureDependences(builder);
			var container = builder.Build();
			DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
		}
	}
}
