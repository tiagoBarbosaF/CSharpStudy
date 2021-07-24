using System;

namespace Functions
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Write three numbers:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int result = Bigger(n1, n2, n3);

            Console.WriteLine("Bigger -> " + result);
        }

        static int Bigger(int a, int b, int c)
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }
    }
}
