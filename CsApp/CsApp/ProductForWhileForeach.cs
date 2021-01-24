using System;
using System.Collections.Generic;
using System.Text;

namespace CsApp
{
    class ProductForWhileForeach
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Apple";
            product1.ProductInfo = "Fruit";
            product1.StockInProcess = 50;

            Product product2 = new Product();
            product2.ProductName = "Pear";
            product2.ProductInfo = "Fruit";
            product2.StockInProcess = 50;

            Product product3 = new Product();
            product3.ProductName = "Banana";
            product3.ProductInfo = "Fruit";
            product3.StockInProcess = 49;

            Product[] products = new Product[] { product1, product2, product3 };

            Console.WriteLine("- - - USED FOR LOOP - - -");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Product Name: " + products[i].ProductName + " --Product Info: " + products[i].ProductInfo + " --Stock In Process: " + products[i].StockInProcess);
            }

            Console.WriteLine("- - - USED WHILE LOOP - - -");
            int x = 0;
            while (x<products.Length)
            {
                Console.WriteLine("Product Name: " + products[x].ProductName + " --Product Info: " + products[x].ProductInfo + " --Stock In Process: " + products[x].StockInProcess);
                x++;
            }

            Console.WriteLine("- - - USED FOREACH LOOP - - -");
            foreach (var k in products)
            {
                Console.WriteLine("Product Name: " + k.ProductName+ " --Product Info: " + k.ProductInfo+ " --Stock In Process: " + k.StockInProcess);
            }

        }
    }
}
