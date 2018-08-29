using AdapterPattern.DomainObjects.DataContracts;

namespace AdapterPattern.DomainObjects
{
	public class Car : ICar
	{
		public string Accelerate()
		{
			return "Accelerating in my car...";
		}
	}
}
