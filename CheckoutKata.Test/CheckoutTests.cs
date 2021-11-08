using NUnit.Framework;
using CheckoutKata.src;
using System.Collections.Generic;

namespace CheckoutKata.Test
{
	public class CheckoutTests
	{

        private IEnumerable<Product> products = new[]
        {
            new Product('A', 10),
            new Product('B', 15, new Discount(3, 5, 0)),
            new Product('C', 40),
            new Product('D', 55, new Discount(2, 0, 25))
        };
		

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
            //CASE FOR PRODUCT B
            var b = new Product('B', 15, new Discount(3, 5, 0));

            checkout.Scan(b);
            checkout.Scan(b);
            checkout.Scan(b);

            Assert.AreEqual(40, checkout.GetTotalPrice());

            //CASE FOR PROD D
            var checkout_2 = new Checkout();
            var d = new Product('D', 55, new Discount(2, 0, 25));

            checkout_2.Scan(d);
            checkout_2.Scan(d);

            Assert.AreEqual(82.5, checkout_2.GetTotalPrice());
        }

        [Test]
        public void Test3_SameProductNoDiscount()
        {
            var checkout = new Checkout();
            //CASE FOR PRODUCT B
            var b = new Product('B', 15, new Discount(3, 5, 0));

            checkout.Scan(b);
            checkout.Scan(b);

            Assert.AreEqual(30, checkout.GetTotalPrice());

            //CASE FOR PROD D
            var checkout_2 = new Checkout();
            var d = new Product('D', 55, new Discount(2, 0, 25));

            checkout_2.Scan(d);

            Assert.AreEqual(55, checkout_2.GetTotalPrice());
        }

        [Test]
        public void Test4_MixedProductsOnDiscount()
		{
            var checkout = new Checkout();

            var b = new Product('B', 15, new Discount(3, 5, 0));
            var d = new Product('D', 55, new Discount(2, 0, 25));

            checkout.Scan(b);
            checkout.Scan(b);
            checkout.Scan(b);

            checkout.Scan(d);
            checkout.Scan(d);

            Assert.AreEqual(122.5, checkout.GetTotalPrice());
        }

        [Test]
        public void Test5_MixedProductsNoDiscount()
        {
            var checkout = new Checkout();

            var a = new Product('A', 10);
            var b = new Product('B', 15, new Discount(3, 5, 0));
            var c = new Product('C', 40);
            var d = new Product('D', 55, new Discount(2, 0, 25));

            checkout.Scan(a);
            checkout.Scan(a);

            checkout.Scan(b);

            checkout.Scan(c);
            checkout.Scan(c);

            checkout.Scan(d);

            Assert.AreEqual(170, checkout.GetTotalPrice());
        }

        [Test]
        public void Test6_MixedProducts()
        {
            var checkout = new Checkout();

            var a = new Product('A', 10);
            var b = new Product('B', 15, new Discount(3, 5, 0));
            var c = new Product('C', 40);
            var d = new Product('D', 55, new Discount(2, 0, 25));

            checkout.Scan(a);
            checkout.Scan(a);
            checkout.Scan(a);
            checkout.Scan(a);

            checkout.Scan(b);
            checkout.Scan(b);
            checkout.Scan(b);
            checkout.Scan(b);

            checkout.Scan(c);
            checkout.Scan(c);

            checkout.Scan(d);
            checkout.Scan(d);
            checkout.Scan(d);

            Assert.AreEqual(312.5, checkout.GetTotalPrice());
        }
    }
}