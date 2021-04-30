using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutKata.src.Interfaces
{
    interface ICheckout
    {
        void Scan(string item);
        int GetTotalPrice();
    }
}
