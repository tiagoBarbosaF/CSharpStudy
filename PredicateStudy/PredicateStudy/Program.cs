using System;
using System.Collections.Generic;
using PredicateStudy.Entities;

namespace PredicateStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            Action<Product> act = UpdatePrice;

            Console.WriteLine("Using Action:");
            list.ForEach(act);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();

            Console.WriteLine("Using extern method");
            list.ForEach(UpdatePrice);
            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();

            Console.WriteLine("Using lambda inline");
            list.ForEach(p => { p.Price += p.Price * 0.1; });
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();


            list.RemoveAll(ProductTest);
            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }

        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.00;
        }
    }
}
