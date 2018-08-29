using DesignPatterns.FactoryPattern.Factories.DataContracts;
using DesignPatterns.FactoryPattern.Services.DataContracts;
using DesignPatterns.FactoryPattern.Vehicles;
using System;

namespace DesignPatterns.FactoryPattern.Services
{
	public class AppService : IAppService
	{
		private readonly IVehicleFactory _vehicleFactory;

		public AppService(IVehicleFactory vehicleFactory)
		{
			_vehicleFactory = vehicleFactory;
		}

		public void Run()
		{
			var car = (Car)_vehicleFactory.Create<Car>();
			Console.WriteLine(car.Description());
			Console.WriteLine(car.CustomCarFact);

			Console.WriteLine();

			var bike = _vehicleFactory.Create<Bike>();
			Console.WriteLine(bike.Description());

			Console.WriteLine();
			Console.WriteLine("Press enter to continue...");
			Console.ReadLine();
		}
	}
}
