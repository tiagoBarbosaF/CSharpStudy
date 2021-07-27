using System;
using GetHashCodeEquals.Entities;

namespace GetHashCodeEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client() { Name = "Maria", Email = "maria@gmail.com" };
            Client b = new Client() { Name = "Tiago", Email = "tiago@gmail.com" };
            Client c = new Client() { Name = "Tiago", Email = "maria@gmail.com" };

            Console.WriteLine($"Client a equals b? {a.Equals(b)}");
            Console.WriteLine($"Client a equals c? {a.Equals(c)}");
            Console.WriteLine($"Client a == b? {a == b}");
            Console.WriteLine($"Client a == c? {a == c}");
            Console.WriteLine($"Client a GetHashCode? {a.GetHashCode()}");
            Console.WriteLine($"Client b GetHashCode? {b.GetHashCode()}");
            Console.WriteLine($"Client c GetHashCode? {c.GetHashCode()}");
        }
    }
}
