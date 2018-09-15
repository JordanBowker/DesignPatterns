using DesignPatterns.ObserverPattern.Services;
using DesignPatterns.ObserverPattern.Services.DataContracts;
using DesignPatterns.ObserverPattern.Subjects;
using DesignPatterns.ObserverPattern.Subjects.DataContracts;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.ObserverPattern
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
			serviceCollection.AddTransient<IForecastTransmitter, ForecastTransmitter>();

			return serviceCollection.BuildServiceProvider();
		}
	}
}
