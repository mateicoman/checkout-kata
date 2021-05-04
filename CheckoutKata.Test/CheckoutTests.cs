using NUnit.Framework;
using CheckoutKata.src;
using System.Collections.Generic;

namespace CheckoutKata.Test
{
	public class CheckoutTests
	{

        private IEnumerable<Product> products = new[]
        {
            new Product('A', 50, new Discount(3, 20)),
            new Product('B', 30, new Discount(2, 15)),
            new Product('C', 20),
            new Product('D', 15)
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
            //CASE FOR PRODUCT A
            var a = new Product('A', 50, new Discount(3, 20));

            checkout.Scan(a);
            checkout.Scan(a);
            checkout.Scan(a);

            Assert.AreEqual(130, checkout.GetTotalPrice());

            //CASE FOR PROD B
            var checkout_2 = new Checkout();
            var b = new Product('B', 30, new Discount(2, 15));

            checkout_2.Scan(b);
            checkout_2.Scan(b);

            Assert.AreEqual(45, checkout_2.GetTotalPrice());
        }

        [Test]
        public void Test3_SameProductNoDiscount()
        {
            var checkout = new Checkout();
            //CASE FOR PRODUCT A
            var a = new Product('A', 50, new Discount(3, 20));

            checkout.Scan(a);
            checkout.Scan(a);

            Assert.AreEqual(100, checkout.GetTotalPrice());

            //CASE FOR PROD B
            var checkout_2 = new Checkout();
            var b = new Product('B', 30, new Discount(2, 15));

            checkout_2.Scan(b);

            Assert.AreEqual(30, checkout_2.GetTotalPrice());
        }

        [Test]
        public void Test4_MixedProductsOnDiscount()
		{
            var checkout = new Checkout();
            
            var a = new Product('A', 50, new Discount(3, 20));
            var b = new Product('B', 30, new Discount(2, 15));

            checkout.Scan(a);
            checkout.Scan(a);
            checkout.Scan(a);

            checkout.Scan(b);
            checkout.Scan(b);

            Assert.AreEqual(175, checkout.GetTotalPrice());
        }

        [Test]
        public void Test5_MixedProductsNoDiscount()
        {
            var checkout = new Checkout();

            var a = new Product('A', 50, new Discount(3, 20));
            var b = new Product('B', 30, new Discount(2, 15));
            var c = new Product('C', 20);
            var d = new Product('D', 15);

            checkout.Scan(a);
            checkout.Scan(a);

            checkout.Scan(b);

            checkout.Scan(c);
            checkout.Scan(c);

            checkout.Scan(d);
            checkout.Scan(d);

            Assert.AreEqual(200, checkout.GetTotalPrice());
        }

        [Test]
        public void Test6_MixedProducts()
        {
            var checkout = new Checkout();

            var a = new Product('A', 50, new Discount(3, 20));
            var b = new Product('B', 30, new Discount(2, 15));
            var c = new Product('C', 20);
            var d = new Product('D', 15);

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

            Assert.AreEqual(340, checkout.GetTotalPrice());
        }
    }
}