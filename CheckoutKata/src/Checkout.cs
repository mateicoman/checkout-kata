using CheckoutKata.src.Interfaces;
using CheckoutKata.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckoutKata.src
{
	public class Checkout : ICheckout
	{
		private List<IProduct> products = new List<IProduct>();
		public void Scan(IProduct product)
		{
			if(product != null)
				products.Add(product);
		}

		public decimal GetTotalPrice()
		{
			decimal total = products.Sum(x => x.Price);

			IEnumerable<char> productsOnOffer = products.Where(x => x.Discount != null).Select(x => x.SKU).Distinct();
			foreach(char sku in productsOnOffer)
			{
				IEnumerable<IProduct> sameProductListFixedDiscount = products.Where(x => x.SKU == sku && x.Discount.DiscountPercentage == 0);
				if(sameProductListFixedDiscount.Any())
					total -= sameProductListFixedDiscount.First().Discount.CalculateDiscountForOneProduct(sameProductListFixedDiscount);

				IEnumerable<IProduct> sameProductListPercentage = products.Where(x => x.SKU == sku && x.Discount.DiscountValue == 0);
				if (sameProductListPercentage.Any())
					total -= sameProductListPercentage.First().Discount.CalculatePercentageDiscount(sameProductListPercentage);
			}

			return total;
		}
	}
}
