using DesignPatterns.ObserverPattern.Observers.DataContracts;
using DesignPatterns.ObserverPattern.Subjects.DataContracts;
using System;
using System.Collections.Generic;

namespace DesignPatterns.ObserverPattern.Subjects
{
	public class ForecastTransmitter : IForecastTransmitter
	{
		public int Temperature { get; private set; }

		public List<IWeatherForecaster> Forecaster { get; set; } = new List<IWeatherForecaster>();

		public void AddForecaster(IWeatherForecaster observer)
		{
			Forecaster.Add(observer);
		}

		public void UpdateTemperature(int temperature)
		{
			if (Temperature == temperature) return;
			Temperature = temperature;
			NotifyForecaster();
		}

		public void NotifyForecaster()
		{
			Forecaster.ForEach(x => x.Update(Temperature));
			Console.WriteLine();
		}

	}
}
