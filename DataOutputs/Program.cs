using System;
using System.Globalization;

namespace DataOutputs
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            char gender = 'F';
            int age = 32;
            double balance = 10.35784;
            string nome = "Tiago";

            Console.Write("Bom dia!");
            Console.WriteLine("Boa tarde!");
            Console.WriteLine("Boa noite!");
            Console.WriteLine("---------------------");
            Console.WriteLine(balance.ToString("F2"));
            Console.WriteLine(balance.ToString("F3"));
            Console.WriteLine(balance.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
