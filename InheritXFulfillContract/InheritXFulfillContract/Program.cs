using System;
using InheritXFulfillContract.Models.Entities;
using InheritXFulfillContract.Models.Enums;

namespace InheritXFulfillContract
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape s1 = new Circle() { radius = 2, color = Color.White };
            IShape s2 = new Rectangle() { width = 3.5, height = 4.2, color = Color.Black };

            Console.WriteLine(s1);
            Console.WriteLine();
            Console.WriteLine(s2);
            Console.WriteLine();
        }
    }
}
