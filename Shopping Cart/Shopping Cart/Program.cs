using System;

namespace Shopping_Cart
{
    class Program
    {
        static void Main()
        {
            Catalog catalog = new Catalog();
            ShoppingCart shoppingCart = new ShoppingCart();
            int response;
            while (true)
            {
                ShowMainMenu();
                try
                {
                    response = int.Parse(Console.ReadLine());
                    switch (response)
                    {
                        case 1:
                            CatalogMenu(catalog, shoppingCart);
                            break;
                        case 2:
                            return;
                        default:
                            Console.WriteLine("Wrong input!");
                            Console.Write("Press any key to continue...");
                            Console.ReadLine();
                            break;
                    }
                } catch (Exception)
                {
                    Console.WriteLine("Wrong input!");
                    Console.Write("Press any key to continue...");
                    Console.ReadLine();
                }
            }
        }

        private static void ShowMainMenu()
        {
            Console.Clear();
            int i = 1;
            Console.WriteLine("---Main menu---");
            Console.WriteLine("{0}.Catalog menu", i++);
            Console.WriteLine("{0}.Exit", i++);
            Console.Write("Select an option: ");
        }

        private static void CatalogMenu(Catalog catalog, ShoppingCart shoppingCart)
        {
            int response;
            while (true)
            {
                ShowCatalogMenu(catalog, shoppingCart);
                try
                {
                    response = int.Parse(Console.ReadLine());
                    switch (response)
                    {
                        case 1:
                            shoppingCart.AddProduct(catalog.Products[response - 1]);
                            break;
                        case 2:
                            shoppingCart.AddProduct(catalog.Products[response - 1]);
                            break;
                        case 3:
                            shoppingCart.AddProduct(catalog.Products[response - 1]);
                            break;
                        case 4:
                            shoppingCart.AddProduct(catalog.Products[response - 1]);
                            break;
                        case 5:
                            shoppingCart.AddProduct(catalog.Products[response - 1]);
                            break;
                        case 6:
                            shoppingCart.AddProduct(catalog.Products[response - 1]);
                            break;
                        case 7:
                            InvoiceMenu(catalog, shoppingCart);
                            break;
                        case 8:
                            return;
                        default:
                            Console.WriteLine("Wrong input!");
                            Console.Write("Press any key to continue...");
                            Console.ReadLine();
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong input!");
                    Console.Write("Press any key to continue...");
                    Console.ReadLine();
                }
            }
        }

        private static void InvoiceMenu(Catalog catalog, ShoppingCart shoppingCart)
        {
            int response;
            while(true)
            {
                ShowInvoiceMenu(catalog, shoppingCart);
                try
                {
                    response = int.Parse(Console.ReadLine());
                    switch (response)
                    {
                        case 1:
                            return;
                        default:
                            Console.WriteLine("Wrong input!");
                            Console.Write("Press any key to continue...");
                            Console.ReadLine();
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong input!");
                    Console.Write("Press any key to continue...");
                    Console.ReadLine();
                }
            }
        }

        private static void ShowCatalogMenu(Catalog catalog, ShoppingCart shoppingCart)
        {
            Console.Clear();
            int i;
            Console.WriteLine("---Products menu---");
            for (i = 0; i < catalog.Products.Count; i++)
            {
                Console.WriteLine("{0}.{1} - ${2}", i + 1, catalog.Products[i].Name, catalog.Products[i].Price);
            }
            Console.WriteLine("{0}.Invoice", ++i);
            Console.WriteLine("{0}.Previous menu", ++i);
            Console.WriteLine("");
            Console.WriteLine("Products in the shopping cart:");

            for (i = 0; i < catalog.Products.Count; i++)
            {
                if (shoppingCart.NumberOfProducts(catalog.Products[i].Name) > 0)
                {
                    Console.WriteLine("{0} X {1}", catalog.Products[i].Name, shoppingCart.NumberOfProducts(catalog.Products[i].Name));
                }
            }
            Console.WriteLine("");
            Console.Write("Select an option: ");
        }

        private static void ShowInvoiceMenu(Catalog catalog, ShoppingCart shoppingCart)
        {
            Console.Clear();
            Console.WriteLine("---Invoice menu---");
            Console.WriteLine("1. Previous menu");
            Console.WriteLine("");
            Console.WriteLine("Products in the shopping cart:");

            for (int i = 0; i < catalog.Products.Count; i++)
            {
                if (shoppingCart.NumberOfProducts(catalog.Products[i].Name) > 0)
                {
                    Console.WriteLine("{0} X {1}", catalog.Products[i].Name, shoppingCart.NumberOfProducts(catalog.Products[i].Name));
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Invoice:");
            Console.WriteLine("Subtotal: ${0}\nShipping: ${1}\nVAT: ${2}\n", shoppingCart.Subtotal, shoppingCart.Shipping, shoppingCart.VAT);
            Console.WriteLine("Discounts:");
            ApplyDiscounts(shoppingCart);
            Console.Write("\n\nSelect an option: ");
        }

        private static void ApplyDiscounts(ShoppingCart shoppingCart)
        {
            double keyboardsDiscount = 0;
            double deskLampDiscount = 0;
            double shippingDiscount = 0;

            if (shoppingCart.Products.Count >= 2)
            {
                shippingDiscount = new Random().Next(1, 10);
                Console.WriteLine("${0} off shipping: -${1}", shippingDiscount, shippingDiscount);
            }
            if (shoppingCart.NumberOfProducts("Keyboard") > 0)
            {
                for (int i = 0; i < shoppingCart.Products.Count; i++)
                {
                    if (shoppingCart.Products[i].Name == "Keyboard")
                    {
                        keyboardsDiscount = shoppingCart.NumberOfProducts("Keyboard") * shoppingCart.Products[i].Price * 0.1;
                        break;
                    }
                }
                Console.WriteLine("10% off keyboards: -${0}", keyboardsDiscount);
            }
            if (shoppingCart.NumberOfProducts("Monitor") >= 2 && shoppingCart.NumberOfProducts("Desk Lamp") >= 1)
            {
                for (int i = 0; i < shoppingCart.Products.Count; i++)
                {
                    if (shoppingCart.Products[i].Name == "Desk Lamp")
                    {
                        if ((int)(shoppingCart.NumberOfProducts("Monitor") / 2) >= shoppingCart.NumberOfProducts("Desk Lamp"))
                        {
                            deskLampDiscount = shoppingCart.NumberOfProducts("Desk Lamp") * shoppingCart.Products[i].Price * 0.5;
                        } else
                        {
                            deskLampDiscount = (int)(shoppingCart.NumberOfProducts("Monitor") / 2) * shoppingCart.Products[i].Price * 0.5;
                        }
                        break;
                    }
                }
                Console.WriteLine("Desk Lamp half price: -${0}", deskLampDiscount);
            }

            Console.WriteLine("\n\nTotal: ${0}", shoppingCart.Subtotal + shoppingCart.Shipping + shoppingCart.VAT - shippingDiscount - keyboardsDiscount - deskLampDiscount);
        }
    }
}
