using DesignPatterns.FacadePattern.DomainObjects;

namespace DesignPatterns.FacadePattern.Services.DataContracts
{
	public interface IPromoCodeService
	{
		void ApplyPromoCode(string code, Order order);
	}
}
