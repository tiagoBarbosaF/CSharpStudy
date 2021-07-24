using System;

namespace RepetitiveStructureWhile
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Write a number: ");
            double x = double.Parse(Console.ReadLine());

            while (x >= 0.0)
            {
                double squareRoot = Math.Sqrt(x);
                Console.WriteLine(squareRoot.ToString("F3"));
                Console.Write("Write another number: ");
                x = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Negative number. Program finished!");
        }
    }
}
