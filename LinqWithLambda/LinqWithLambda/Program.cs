﻿using System;
using System.Linq;
using System.Collections.Generic;
using LinqWithLambda.Entities;

namespace LinqWithLambda
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2},
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1},
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3},
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2},
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1},
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2},
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3},
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3},
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2},
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3},
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1}
            };

            //var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            var r1 =
                from p in products
                where p.Category.Tier == 1 && p.Price < 900.0
                select p;
            Print("Tier 1 and Price < 900:", r1);

            //var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            var r2 = from p in products where p.Category.Name == "Tools" select p.Name;
            Print("Names of products from Tools:", r2);

            //var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            var r3 = from p in products where p.Name[0] == 'C' select new { p.Name, p.Price, CategoryName = p.Category.Name };
            Print("Names started with 'C' and anonymous objects", r3);

            //var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            var r4 = from p in products where p.Category.Tier == 1 orderby p.Name orderby p.Price select p;
            Print("Product with Category Tier 1 ordered by Price and Name:", r4);

            //var r5 = r4.Skip(2).Take(4);
            var r5 = (from p in r4 select p).ToList().Skip(2).Take(4);
            Print("Product with Category Tier 1 ordered by Price and Name, Skip 2 and Take 4:", r5);

            Console.WriteLine();
            //var r17 = products.GroupBy(p => p.Category);
            var r17 = from p in products group p by p.Category;
            foreach (IGrouping<Category, Product> group in r17)
            {
                Console.WriteLine($"Category {group.Key.Name}:");
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
        }
    }
}
