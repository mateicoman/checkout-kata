using CheckoutKata.src.Interfaces;
using CheckoutKata.Types;
using System;

namespace CheckoutKata
{
	public class Product : IProduct
	{
		public char SKU { get; set; }
		public int Price { get; set; }
		public IDiscount Discount { get; set; }
	}
}
