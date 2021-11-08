using CheckoutKata.src.Interfaces;
using CheckoutKata.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckoutKata.src
{
	public class Discount: IDiscount
	{
		public int NumberOfItemsRequired { get; set; }
		public decimal DiscountValue { get; set; }
		public decimal DiscountPercentage { get; set; }

		public Discount(int _noOfItemsRequired, decimal _discountValue, decimal _discountPercentage)
		{
			NumberOfItemsRequired = _noOfItemsRequired;
			DiscountValue = _discountValue;
			DiscountPercentage = _discountPercentage;
		}

		public decimal CalculateDiscountForOneProduct(IEnumerable<IProduct> list)
		{
			return (list.Count() / NumberOfItemsRequired) * DiscountValue;
		}

		public decimal CalculatePercentageDiscount(IEnumerable<IProduct> list)
		{
			decimal total = list.Sum(x => Convert.ToDecimal(x));
			return total - (list.Count() / NumberOfItemsRequired) * (DiscountPercentage/100);
		}
	}
}
