using System;

namespace ComparativeOperators
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = 10;
            bool c1 = a < 10;
            bool c2 = a < 20;
            bool c3 = a > 10;
            bool c4 = a > 5;
            bool c5 = a <= 10;
            bool c6 = a >= 10;
            bool c7 = a == 10;
            bool c8 = a != 10;

            Console.WriteLine("Comparative Operators:");
            Console.WriteLine($"a < 10 -> {c1}");
            Console.WriteLine($"a < 20 -> {c2}");
            Console.WriteLine($"a > 10 -> {c3}");
            Console.WriteLine($"a > 5 -> {c4}");
            Console.WriteLine($"a <= 10 -> {c5}");
            Console.WriteLine($"a >= 10 -> {c6}");
            Console.WriteLine($"a == 10 -> {c7}");
            Console.WriteLine($"a != 10 -> {c8}");
        }
    }
}
