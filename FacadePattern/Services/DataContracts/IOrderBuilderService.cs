using DesignPatterns.FacadePattern.DomainObjects;

namespace DesignPatterns.FacadePattern.Services.DataContracts
{
	public interface IOrderBuilderService
	{
		Order BuildOrder(Product product, int quantity, string promoCode);
	}
}
