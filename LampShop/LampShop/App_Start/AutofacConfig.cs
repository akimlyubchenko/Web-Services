using Repository;
using Repository.Contexts;
using RepositoryInterface;

namespace LampShop.App_Start
{
	using Autofac;
	using Autofac.Integration.Mvc;
	using Services.Lamp;

	public class AutofacConfig
	{
		public static void ConfigureDependences(ContainerBuilder builder)
		{
			builder.RegisterControllers(typeof(MvcApplication).Assembly);

			builder.RegisterType<LampRepository>().As<ILampRepository>();
			builder.RegisterType<LampDBContext>().AsSelf();

			builder.RegisterType<LampService>().AsSelf();
		}
	}
}