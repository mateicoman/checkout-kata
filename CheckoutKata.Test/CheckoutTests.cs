using NUnit.Framework;
using CheckoutKata.src;

namespace CheckoutKata.Test
{
	public class CheckoutTests
	{

        [Test]
        public void Test1_NoProductScanned()
        {
            var checkout = new Checkout();
            Assert.AreEqual(0, checkout.GetTotalPrice());
        }

        [Test]
        public void Test2_SameProductOnDiscount()
        {
            var checkout = new Checkout();
            var a = new Product('A', 50, new Discount(3, 20));

            checkout.Scan(a);
            checkout.Scan(a);
            checkout.Scan(a);
            Assert.AreEqual(130, checkout.GetTotalPrice());
        }

        [Test]
        public void Test3_SameProductNoDiscount()
        {

        }

        [Test]
        public void Test4_MixedProductsOnDiscount()
		{

		}

        [Test]
        public void Test5_MixedProductsNoDiscount()
        {

        }

        [Test]
        public void Test6_MixedProducts()
        {

        }
    }
}