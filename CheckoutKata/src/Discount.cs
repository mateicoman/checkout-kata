using CheckoutKata.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckoutKata.src
{
	public class Discount
	{
		public int NumberOfItems { get; set; }
		public int DiscountValue { get; set; }

		public int CalculateDiscountForOneProduct(IEnumerable<IProduct> list)
		{
			return (list.Count() / NumberOfItems) * DiscountValue;
		}
	}
}
