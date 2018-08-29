using DesignPatterns.FacadePattern.Services;
using DesignPatterns.FacadePattern.Services.DataContracts;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.FacadePattern
{
	class Program
	{
		static void Main(string[] args)
		{
			var services = ConfigureServices();
			services.GetService<IAppService>().Run();
		}

		private static ServiceProvider ConfigureServices()
		{
			var serviceCollection = new ServiceCollection();

			serviceCollection.AddTransient<IAppService, AppService>();
			serviceCollection.AddTransient<IDiscountService, DiscountService>();
			serviceCollection.AddTransient<IPromoCodeService, PromoCodeService>();
			serviceCollection.AddTransient<IOrderBuilderService, OrderBuilderService>();

			return serviceCollection.BuildServiceProvider();
		}
	}
}
