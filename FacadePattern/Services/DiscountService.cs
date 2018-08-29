using DesignPatterns.FacadePattern.DomainObjects;
using DesignPatterns.FacadePattern.Services.DataContracts;

namespace DesignPatterns.FacadePattern.Services
{
	public class DiscountService : IDiscountService
	{
		public void ApplyDiscount(Order order)
		{
			if (order.Quantity > 10) order.DiscountAmount += 100;
		}
	}
}
