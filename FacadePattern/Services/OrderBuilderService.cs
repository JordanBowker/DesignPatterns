using DesignPatterns.FacadePattern.DomainObjects;
using DesignPatterns.FacadePattern.Services.DataContracts;

namespace DesignPatterns.FacadePattern.Services
{
	public class OrderBuilderService : IOrderBuilderService
	{
		private readonly IDiscountService _discountService;
		private readonly IPromoCodeService _promoCodeService;

		public OrderBuilderService(IDiscountService discountService, IPromoCodeService promoCodeService)
		{
			_discountService = discountService;
			_promoCodeService = promoCodeService;
		}

		public Order BuildOrder(Product product, int quantity, string promoCode)
		{
			var order = new Order(product, quantity);

			_discountService.ApplyDiscount(order);
			_promoCodeService.ApplyPromoCode(promoCode, order);

			return order;
		}
	}
}
