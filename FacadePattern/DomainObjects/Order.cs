namespace DesignPatterns.FacadePattern.DomainObjects
{
	public class Order
	{
		public Product Product { get; set; }
		public int Quantity { get; set; }
		public decimal DiscountAmount { get; set; } = 0;
		public decimal TotalPriceBeforeDiscount => Product.Price * Quantity;
		public decimal TotalPriceAfterDiscount => TotalPriceBeforeDiscount - DiscountAmount;

		public Order(Product product, int quantity)
		{
			Product = product;
			Quantity = quantity;
		}
	}
}
