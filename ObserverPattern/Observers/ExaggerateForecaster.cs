using DesignPatterns.ObserverPattern.Observers.DataContracts;
using System;

namespace DesignPatterns.ObserverPattern.Observers
{
	public class ExaggerateForecaster : IWeatherForecaster
	{
		public void Update(int temperature)
		{
			Console.WriteLine($"The 'Exaggerate' temperature is: {temperature + 20} degrees.");
		}
	}
}
