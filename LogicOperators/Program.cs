using System;

namespace LogicOperators
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool c1 = 2 > 3 || 4 != 5;
            bool c2 = !(2 > 3) && 4 != 5;
            bool c3 = 10 < 5;
            bool c4 = c1 || c2 && c3;

            Console.WriteLine("Logic Operators:");
            Console.WriteLine($"C1: 2 > 3 || 4 != 5 -> {c1}");
            Console.WriteLine($"C2: !(2 > 3) && 4 != 5 -> {c2}");
            Console.WriteLine($"C3: 10 < 5 -> {c3}");
            Console.WriteLine($"C4: c1 || c2 && c3 -> {c4}");
        }
    }
}
