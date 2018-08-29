using AdapterPattern.DomainObjects.DataContracts;
using AdapterPattern.Services.DataContracts;
using System;

namespace AdapterPattern.Services
{
	public class ClientService : IClientService
	{
		public void InvokeAccelerate(ICar car)
		{
			Console.WriteLine(car.Accelerate());
		}
	}
}
