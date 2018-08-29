using DesignPatterns.FactoryPattern.Vehicles.DataContracts;

namespace DesignPatterns.FactoryPattern.Vehicles
{
	public abstract class AbstractVehicle : IVehicle
	{
		public abstract string Name { get; }
		public abstract int NumberOfWheels { get; }

		public string Description()
		{
			return $"A {Name} has {NumberOfWheels} wheels.";
		}
	}
}
