using DesignPatterns.ObserverPattern.Observers;
using DesignPatterns.ObserverPattern.Services.DataContracts;
using DesignPatterns.ObserverPattern.Subjects.DataContracts;
using System;

namespace DesignPatterns.ObserverPattern.Services
{
	public class AppService : IAppService
	{
		private readonly IForecastTransmitter _forecastTransmitter;

		public AppService(IForecastTransmitter forecastTransmitter)
		{
			_forecastTransmitter = forecastTransmitter;
		}

		public void Run()
		{
			_forecastTransmitter.AddForecaster(new AccurateForecaster());
			_forecastTransmitter.AddForecaster(new ExaggerateForecaster());
			_forecastTransmitter.AddForecaster(new UnexaggeratedForecaster());

			_forecastTransmitter.UpdateTemperature(100);
			_forecastTransmitter.UpdateTemperature(20);
			_forecastTransmitter.UpdateTemperature(40);

			Console.WriteLine();
			Console.WriteLine("Press enter to end.");
			Console.ReadLine();
		}
	}
}
