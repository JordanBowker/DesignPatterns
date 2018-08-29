using DesignPatterns.FacadePattern.DomainObjects;
using DesignPatterns.FacadePattern.Services.DataContracts;

namespace DesignPatterns.FacadePattern.Services
{
	public class PromoCodeService : IPromoCodeService
	{
		public void ApplyPromoCode(string code, Order order)
		{
			if (code == "c0d3") order.DiscountAmount += 100;
		}
	}
}
