using System;

namespace ParamsRefOut
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double a = 10;
            Console.WriteLine("Representando Params ref:");
            Calculator.TripleRef(ref a);
            Console.WriteLine(a);

            Console.WriteLine();
            Console.WriteLine("Representando Params Out:");
            double b = 20.5;
            double triple;
            Calculator.TripleOut(b, out triple);
            Console.WriteLine(triple);
        }
    }
}
