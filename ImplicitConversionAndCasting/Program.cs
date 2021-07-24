using System;

namespace ImplicitConversionAndCasting
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double a;
            float b;

            a = 5.1;
            b = (float)a;

            Console.WriteLine(b);
            Console.WriteLine("----------------");

            double c;
            int d;

            a = 5.1;
            b = (int)a;
            Console.WriteLine(b);
            Console.WriteLine("----------------");

            int e = 5;
            int f = 2;
            double result1 = e / f;
            double result2 = (double)e / f;
            Console.WriteLine($"No cast -> {result1}");
            Console.WriteLine($"With cast -> {result2}");
        }
    }
}
