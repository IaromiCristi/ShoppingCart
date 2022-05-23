using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping_Cart
{
    class ShoppingCart
    {
        public List<Product> Products { get; }
        public double Subtotal { set; get; }
        public double Shipping { set; get; }
        public double VAT { set; get; }

        public ShoppingCart()
        {
            Products = new List<Product>();
            Subtotal = 0;
            Shipping = 0;
            VAT = 0;
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
            Subtotal += product.Price;
            Shipping += product.Weight * 10 * product.ShippingCountry.Rate;
            VAT = 0.19 * Subtotal;
        }

        public int NumberOfProducts(string productName)
        {
            int numberOfProducts = 0;
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].Name == productName)
                {
                    numberOfProducts++;
                }
            }
            return numberOfProducts;
        }

    }
}
