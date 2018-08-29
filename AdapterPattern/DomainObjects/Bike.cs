using AdapterPattern.DomainObjects.DataContracts;

namespace AdapterPattern.DomainObjects
{
	public class Bike : IBike
	{
		public string Pedal()
		{
			return "Pedalling on my bike...";
		}
	}
}
