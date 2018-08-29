using DesignPatterns.FactoryPattern.Factories;
using DesignPatterns.FactoryPattern.Factories.DataContracts;
using DesignPatterns.FactoryPattern.Services;
using DesignPatterns.FactoryPattern.Services.DataContracts;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.FactoryPattern
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
			serviceCollection.AddTransient<IVehicleFactory, VehicleFactory>();

			return serviceCollection.BuildServiceProvider();
		}
	}
}
