using DesignPatterns.ObserverPattern.Observers.DataContracts;
using System.Collections.Generic;

namespace DesignPatterns.ObserverPattern.Subjects.DataContracts
{
	public interface IForecastTransmitter
	{
		int Temperature { get; }
		List<IWeatherForecaster> Forecaster { get; set; }
		void AddForecaster(IWeatherForecaster observer);
		void UpdateTemperature(int temperature);
		void NotifyForecaster();
	}
}
