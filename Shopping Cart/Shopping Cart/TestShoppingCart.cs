using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping_Cart
{
    [TestClass]
    class TestShoppingCart
    {
        [TestMethod]
        public void TestNumberOfProducts()
        {
            ShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.AddProduct(new Product("Keyboard", 40.99, 0.7, new Country("UK", 2)));

            var result = shoppingCart.NumberOfProducts("Keyboard");
            Assert.Equals(result, 1);
            var result1 = shoppingCart.NumberOfProducts("Mouse");
            Assert.Equals(result1, 0);
        }

        [TestMethod]
        public void TestAddProduct()
        {
            ShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.AddProduct(new Product("Keyboard", 40.99, 0.7, new Country("UK", 2)));

            var result = shoppingCart.Subtotal;
            Assert.Equals(shoppingCart.Products.Count, 1);
            Assert.Equals(result, 40.99);
            Assert.Equals(shoppingCart.Shipping, 14);
        }
    }
}
