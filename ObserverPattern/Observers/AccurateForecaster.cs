using DesignPatterns.ObserverPattern.Observers.DataContracts;
using System;

namespace DesignPatterns.ObserverPattern.Observers
{
	public class AccurateForecaster : IWeatherForecaster
	{
		public void Update(int temperature)
		{
			Console.WriteLine($"The 'Accurate' temperature is: {temperature} degrees.");
		}
	}
}
