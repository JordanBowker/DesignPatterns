using AdapterPattern.Adapters;
using AdapterPattern.DomainObjects;
using AdapterPattern.Services.DataContracts;
using System;

namespace AdapterPattern.Services
{
	public class AppService : IAppService
	{
		private readonly IClientService _clientService;

		public AppService(IClientService clientService)
		{
			_clientService = clientService;
		}

		public void Run()
		{
			Console.WriteLine("Invoking accelerate on the car");
			_clientService.InvokeAccelerate(new Car());

			Console.WriteLine("");

			Console.WriteLine("Invoking accelerate on the bike, using the adapter");
			var bikeAdapter = new BikeAdapter(new Bike());
			_clientService.InvokeAccelerate(bikeAdapter);

			Console.WriteLine();
			Console.WriteLine("Press enter to continue...");
			Console.ReadLine();
		}
	}
}
