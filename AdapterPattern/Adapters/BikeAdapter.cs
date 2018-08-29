using AdapterPattern.DomainObjects.DataContracts;

namespace AdapterPattern.Adapters
{
	public class BikeAdapter : ICar
	{
		private readonly IBike _bike;

		public BikeAdapter(IBike bike)
		{
			_bike = bike;
		}

		public string Accelerate()
		{
			return _bike.Pedal();
		}
	}
}
