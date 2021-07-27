using System;

namespace ExtensionMethodsStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2021, 7, 20, 8, 14, 35);
            Console.WriteLine($"DateTime => {dt.ElapsedTime()}");

            Console.WriteLine();
            string s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));
        }
    }
}
