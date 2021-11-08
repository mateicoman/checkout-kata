using CheckoutKata.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutKata.src.Interfaces
{
    public interface ICheckout
    {
        void Scan(IProduct product);
        decimal GetTotalPrice();
    }
}
