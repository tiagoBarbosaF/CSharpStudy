using System;
using System.Globalization;

namespace DateTimeFunctions
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("DateTime - Construtores:");
            DateTime d1 = new DateTime(2022, 12, 5);
            DateTime d2 = new DateTime(2022, 12, 5, 14, 34, 50);
            DateTime d3 = new DateTime(2022, 12, 5, 16, 36, 23, 520);
            Console.WriteLine($"d1 -> {d1}");
            Console.WriteLine($"d2 -> {d2}");
            Console.WriteLine($"d3 -> {d3}");

            Console.WriteLine("-----------------------------");
            Console.WriteLine("DateTime - Now, UtcNow, Today:");
            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.UtcNow;
            DateTime d6 = DateTime.Today;
            Console.WriteLine($"d4 -> {d4}");
            Console.WriteLine($"d5 -> {d5}");
            Console.WriteLine($"d6 -> {d6}");

            Console.WriteLine("-----------------------------");
            Console.WriteLine("DateTime - Parse:");
            DateTime d7 = DateTime.Parse("2022-12-5");
            DateTime d8 = DateTime.Parse("2022-12-5 14:13:22");
            DateTime d9 = DateTime.Parse("5/12/2022");
            DateTime d10 = DateTime.Parse("5/12/2022 16:43:25");
            Console.WriteLine($"d7 -> {d7}");
            Console.WriteLine($"d8 -> {d8}");
            Console.WriteLine($"d9 -> {d9}");
            Console.WriteLine($"d10 -> {d10}");

            Console.WriteLine("-----------------------------");
            Console.WriteLine("DateTime - ParseExact:");
            DateTime d11 = DateTime.ParseExact("2022-12-23", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d12 = DateTime.ParseExact("23/12/2022 14:13:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine($"d11 -> {d11}");
            Console.WriteLine($"d12 -> {d12}");

        }
    }
}
