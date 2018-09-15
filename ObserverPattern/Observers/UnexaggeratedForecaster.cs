using DesignPatterns.ObserverPattern.Observers.DataContracts;
using System;

namespace DesignPatterns.ObserverPattern.Observers
{
	public class UnexaggeratedForecaster : IWeatherForecaster
	{
		public void Update(int temperature)
		{
			Console.WriteLine($"The 'Unexaggerate' temperature is: {temperature - 20} degrees.");
		}
	}
}
