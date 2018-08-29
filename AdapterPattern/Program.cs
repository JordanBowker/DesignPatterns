using AdapterPattern.Services;
using AdapterPattern.Services.DataContracts;
using Microsoft.Extensions.DependencyInjection;

namespace AdapterPattern
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
			serviceCollection.AddTransient<IClientService, ClientService>();

			return serviceCollection.BuildServiceProvider();
		}
	}
}
