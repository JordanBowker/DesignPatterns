using DesignPatterns.FactoryPattern.Factories.DataContracts;
using DesignPatterns.FactoryPattern.Vehicles.DataContracts;

namespace DesignPatterns.FactoryPattern.Factories
{
	public class VehicleFactory : IVehicleFactory
	{
		public IVehicle Create<T>() where T : IVehicle, new()
		{
			return new T();
		}
	}
}
