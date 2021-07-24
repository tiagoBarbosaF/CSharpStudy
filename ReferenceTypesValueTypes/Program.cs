using System;

namespace ReferenceTypesValueTypes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Point p;
            p.x = 10;
            p.y = 20;

            Console.WriteLine(p);

            Point p1 = new Point();
            Console.WriteLine(p1);
        }
    }
}
