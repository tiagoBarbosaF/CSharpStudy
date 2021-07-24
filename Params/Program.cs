using System;

namespace Params
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double result = Calculator.Sum(10, 20, 30.5, 50);
            Console.WriteLine($"Resultado da soma: {result}");
        }
    }
}
