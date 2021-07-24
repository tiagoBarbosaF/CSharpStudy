using System;

namespace CourseBaseTypes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool complete = false;
            char gender = 'F';
            char letterUnicode = '\u0041';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5F;
            double n6 = 4.5;
            int n7 = int.MinValue;
            int n8 = int.MaxValue;
            decimal n9 = decimal.MaxValue;
            String nome = "Tiago Barbosa";
            Object obj1 = "Alex Kid";
            Object obj2 = 4.5F;

            Console.WriteLine(complete);
            Console.WriteLine(gender);
            Console.WriteLine(letterUnicode);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(n7);
            Console.WriteLine(n8);
            Console.WriteLine(n9);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
        }
    }
}
