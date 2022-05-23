using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping_Cart
{
    class Catalog
    {
        public List<Product> Products { get; }

        public Catalog()
        {
            Products = new List<Product>();
            Country ro = new Country("RO", 1);
            Country uk = new Country("UK", 2);
            Country us = new Country("US", 3);
            Product mouse = new Product("Mouse", 10.99, 0.2, ro);
            Product keyboard = new Product("Keyboard", 40.99, 0.7, uk);
            Product monitor = new Product("Monitor", 164.99, 1.9, us);
            Product webcam = new Product("Webcam", 84.99, 0.2, ro);
            Product headphones = new Product("Headphones", 59.99, 0.6, us);
            Product deskLamp = new Product("Desk Lamp", 89.99, 1.3, uk);
            Products.Add(mouse);
            Products.Add(keyboard);
            Products.Add(monitor);
            Products.Add(webcam);
            Products.Add(headphones);
            Products.Add(deskLamp);
        }

    }
}
