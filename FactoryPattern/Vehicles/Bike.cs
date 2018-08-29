namespace DesignPatterns.FactoryPattern.Vehicles
{
	public class Bike : AbstractVehicle
	{
		public override string Name => "Bike";
		public override int NumberOfWheels => 2;
	}
}
