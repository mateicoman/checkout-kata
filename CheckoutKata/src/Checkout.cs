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
			products.Add(product);
		}

		public int GetTotalPrice()
		{
			int total = products.Sum(x => x.Price);

			IEnumerable<char> productsOnOffer = products.Where(x => x.Discount != null).Select(x => x.SKU);
			foreach(char sku in productsOnOffer)
			{
				IEnumerable<IProduct> sameProductList = products.Where(x => x.SKU == sku);
				if(sameProductList.Any())
					total -= sameProductList.First().Discount.CalculateDiscountForOneProduct(sameProductList);
			}

			return total;
		}
	}
}
