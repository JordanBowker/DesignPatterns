using AdapterPattern.DomainObjects.DataContracts;

namespace AdapterPattern.Services.DataContracts
{
	public interface IClientService
	{
		void InvokeAccelerate(ICar car);
	}
}
