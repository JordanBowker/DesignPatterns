namespace DesignPatterns.FactoryPattern.Vehicles
{
	public class Car : AbstractVehicle
	{
		public override string Name => "Car";
		public override int NumberOfWheels => 4;

		public string CustomCarFact => "A car has a record speed of 435.31 km/h.";
	}
}
