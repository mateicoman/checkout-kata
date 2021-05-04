using CheckoutKata.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutKata.src.Interfaces
{
    interface ICheckout
    {
        void Scan(IProduct product);
        int GetTotalPrice();
    }
}
