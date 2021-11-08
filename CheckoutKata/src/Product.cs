using CheckoutKata.src;
using CheckoutKata.src.Interfaces;
using CheckoutKata.Types;
using System;

namespace CheckoutKata
{
	public class Product : IProduct
	{
		public char SKU { get; set; }
		public decimal Price { get; set; }
		public Discount Discount { get; set; }

		public Product(char _sku, decimal _price, Discount _discount = null)
		{
			SKU = _sku;
			Price = _price;
			Discount = _discount;

		}
	}
}
