using System;

namespace ConditionalStructureIfElse
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What time is it?");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Good morning!");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Good afternoon!");
            }
            else
            {
                Console.WriteLine("Good evening!");
            }
        }
    }
}
