using System;

namespace AssignmentOperators
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);
            Console.WriteLine("-----------------------");

            int b = 10;
            b++;
            Console.WriteLine(b);
            Console.WriteLine("-----------------------");

            int c = 10;
            int d = c++;
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine("-----------------------");

            int e = 10;
            int f = ++e;
            Console.WriteLine(e);
            Console.WriteLine(f);

        }
    }
}
