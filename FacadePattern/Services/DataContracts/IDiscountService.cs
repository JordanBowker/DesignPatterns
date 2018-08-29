using DesignPatterns.FacadePattern.DomainObjects;

namespace DesignPatterns.FacadePattern.Services.DataContracts
{
	public interface IDiscountService
	{
		void ApplyDiscount(Order order);
	}
}
