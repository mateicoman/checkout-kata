using CheckoutKata.src.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutKata.Types
{
	public interface IProduct
	{
		char SKU { get; set; }
		int Price { get; set; }
		IDiscount Discount { get; set; }
}
}
