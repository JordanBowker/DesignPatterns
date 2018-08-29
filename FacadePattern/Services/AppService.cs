using DesignPatterns.FacadePattern.DomainObjects;
using DesignPatterns.FacadePattern.Services.DataContracts;
using System;

namespace DesignPatterns.FacadePattern.Services
{
	public class AppService : IAppService
	{
		private readonly IOrderBuilderService _orderBuilder;

		public AppService(IOrderBuilderService orderBuilder)
		{
			_orderBuilder = orderBuilder;
		}

		public void Run()
		{
			var product = new Product();
			var order = _orderBuilder.BuildOrder(product, 20, "c0d3");

			Console.WriteLine($"Order built with {order.Quantity} '{order.Product.Name}' products.");
			Console.WriteLine($"Order total: {order.TotalPriceBeforeDiscount}");
			Console.WriteLine($"Discounts applied: {order.DiscountAmount}");
			Console.WriteLine($"Price to pay: {order.TotalPriceAfterDiscount}");

			Console.WriteLine();
			Console.WriteLine("Press enter to continue...");
			Console.ReadLine();
		}
	}
}
