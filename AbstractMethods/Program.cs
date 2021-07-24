using System;
using System.Collections.Generic;
using AbstractMethods.Entities;
using AbstractMethods.Entities.Enums;

namespace AbstractMethods
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.WriteLine("== Shapes and Colors ==");
            Console.WriteLine();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nShape #{i} data:");
                Console.Write("Rectangle or Ciscle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = (Color)Enum.Parse(typeof(Color), Console.ReadLine());
                if (ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());
                    list.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    list.Add(new Circle(radius, color));
                }
            }
            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS");
            foreach (Shape shape in list)
            {
                Console.WriteLine($"{shape.Area():F2}");
            }

        }
    }
}
