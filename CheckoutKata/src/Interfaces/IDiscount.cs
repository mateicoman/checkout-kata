using CheckoutKata.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutKata.src.Interfaces
{
	public interface IDiscount
	{
		int NumberOfItemsRequired { get; set; }
		decimal DiscountValue { get; set; }
		decimal DiscountPercentage { get; set; }

		decimal CalculateDiscountForOneProduct(IEnumerable<IProduct> list);
		decimal CalculatePercentageDiscount(IEnumerable<IProduct> list);
	}
}
