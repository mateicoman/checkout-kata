using CheckoutKata.src.Interfaces;
using CheckoutKata.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutKata.src
{
	public class Checkout : ICheckout
	{
		public void Scan(IProduct product)
		{
			throw new NotImplementedException();
		}

		public int GetTotalPrice()
		{
			throw new NotImplementedException();
		}
	}
}
