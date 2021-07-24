using System;

namespace Foreach
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] arr = new string[] { "Maria", "Alex", "Tiago" };

            Console.WriteLine("Usando For");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("----------------");

            Console.WriteLine("Usando Foreach:");
            foreach (string obj in arr)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
