using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping_Cart
{
    class Product
    {
        public string Name { get; }
        public double Price { get; }
        public double Weight { get; }
        public Country ShippingCountry { get; }

        public Product(string name, double price, double weight, Country shippingCountry)
        {
            Name = name;
            Price = price;
            Weight = weight;
            ShippingCountry = shippingCountry;
        }

    }
}
