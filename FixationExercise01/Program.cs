using System;
using System.Globalization;

namespace FixationExercise01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string product01 = "Computer";
            string product02 = "Office table";

            byte age = 30;
            int code = 5290;
            char gender = 'M';

            double price01 = 2100;
            double price02 = 650.50;
            double measure = 53.234567;

            Console.WriteLine("Products:");
            Console.WriteLine($"{product01}, whose price is $ {price01}.");
            Console.WriteLine($"{product02}, whose price is $ {price02}.");
            Console.WriteLine();
            Console.WriteLine($"Register: {age} years old, code {code} and gender: {gender}.");
            Console.WriteLine();
            Console.WriteLine($"Measure with eight decimal places: {measure:F8}");
            Console.WriteLine($"Round (three decimal places): {measure:F3}");
            Console.WriteLine("Decimal separator invariant culture: " + measure.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
