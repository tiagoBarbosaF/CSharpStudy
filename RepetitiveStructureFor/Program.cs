using System;

namespace RepetitiveStructureFor
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("How many Integer number do you write? ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Value #{i}: ");
                int value = int.Parse(Console.ReadLine());
                sum += value;
            }

            Console.WriteLine($"Sum = {sum}");
        }
    }
}
