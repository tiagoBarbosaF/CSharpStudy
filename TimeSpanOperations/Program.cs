﻿using System;

namespace TimeSpanOperations
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("TimeSpan - MaxValue, MinValue, Zero:");

            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;

            Console.WriteLine($"TimeSpan MaxValue -> {t1}");
            Console.WriteLine($"TimeSpan MinValue -> {t2}");
            Console.WriteLine($"TimeSpan Zero -> {t3}");

            Console.WriteLine();
            Console.WriteLine("-------------------------");
            Console.WriteLine("TimeSpan Properties:");

            TimeSpan t4 = new TimeSpan(2, 3, 5, 7, 11);

            Console.WriteLine($"Time -> {t4}");

            Console.WriteLine($"Days -> {t4.Days}");
            Console.WriteLine($"Hours -> {t4.Hours}");
            Console.WriteLine($"Minutes -> {t4.Minutes}");
            Console.WriteLine($"Milliseconds -> {t4.Milliseconds}");
            Console.WriteLine($"Seconds -> {t4.Seconds}");
            Console.WriteLine($"Ticks -> {t4.Ticks}");
            Console.WriteLine($"TotalDays -> {t4.TotalDays}");
            Console.WriteLine($"TotalHours -> {t4.TotalHours}");
            Console.WriteLine($"TotalMinutes -> {t4.TotalMinutes}");
            Console.WriteLine($"TotalSeconds -> {t4.TotalSeconds}");
            Console.WriteLine($"TotalMilliseconds -> {t4.TotalMilliseconds}");

            Console.WriteLine();
            Console.WriteLine("-------------------------");
            Console.WriteLine("TimeSpan Operations:");

            TimeSpan t5 = new TimeSpan(1, 30, 10);
            TimeSpan t6 = new TimeSpan(0, 10, 5);

            TimeSpan sum = t5.Add(t6);
            TimeSpan dif = t5.Subtract(t6);
            //TimeSpan mult = t6.Multiply(2.0);
            //TimeSpan div = t5.Divide(t6);

            Console.WriteLine(t5);
            Console.WriteLine(t6);
            Console.WriteLine($"TimeSpan Add -> {sum}");
            Console.WriteLine($"TimeSpan Subtract -> {dif}");
        }
    }
}
