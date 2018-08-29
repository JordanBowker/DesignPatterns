namespace DesignPatterns.FactoryPattern.Vehicles.DataContracts
{
	public interface IVehicle
	{
		int NumberOfWheels { get; }
		string Name { get; }
		string Description();
	}
}
