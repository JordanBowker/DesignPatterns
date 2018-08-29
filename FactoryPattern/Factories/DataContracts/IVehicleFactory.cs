using DesignPatterns.FactoryPattern.Vehicles.DataContracts;

namespace DesignPatterns.FactoryPattern.Factories.DataContracts
{
	public interface IVehicleFactory
	{
		IVehicle Create<T>() where T : IVehicle, new();
	}
}
