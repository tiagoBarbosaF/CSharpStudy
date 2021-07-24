using System;

namespace TimeSpanFunctions
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("TimeSpan - Constructors:");
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 21);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);

            Console.WriteLine($"t1 -> {t1}");
            Console.WriteLine($"t2 -> {t2}");
            Console.WriteLine($"t3 -> {t3}");
            Console.WriteLine($"t4 -> {t4}");
            Console.WriteLine($"t5 -> {t5}");

            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("TimeSpan - Methods From:");
            TimeSpan t6 = TimeSpan.FromDays(1.5);
            TimeSpan t7 = TimeSpan.FromHours(1.5);
            TimeSpan t8 = TimeSpan.FromMinutes(1.5);
            TimeSpan t9 = TimeSpan.FromSeconds(1.5);
            TimeSpan t10 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t11 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine($"FromDays -> {t6}");
            Console.WriteLine($"FromHours -> {t7}");
            Console.WriteLine($"FromMinutes -> {t8}");
            Console.WriteLine($"FromSeconds -> {t9}");
            Console.WriteLine($"FromMilliseconds -> {t10}");
            Console.WriteLine($"FromTicks -> {t11}");
        }
    }
}
