using System;

namespace StaticMembers01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Calculadora.Circuferencia(raio);
            double volm = Calculadora.Volume(raio);

            Console.WriteLine($"Circunferência: {circ:F2}");
            Console.WriteLine($"Volume: {volm:F2}");
            Console.WriteLine($"Valor de Pi: {Calculadora.Pi}");

        }
    }
}
