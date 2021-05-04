using CheckoutKata.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutKata.src.Interfaces
{
	public interface IDiscount
	{
		int NumberOfItems { get; set; }
		int DiscountValue { get; set; }

		int CalculateDiscountForOneProduct(IEnumerable<IProduct> list);
	}
}
