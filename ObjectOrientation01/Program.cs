using System;

namespace ObjectOrientation01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double areaX = x.Area();

            double areaY = y.Area();

            Console.WriteLine($"Área de X = {areaX:F4}");
            Console.WriteLine($"Área de Y = {areaY:F4}");

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }

            //double xA, xB, xC, yA, yB, yC;

            //Console.WriteLine("Entre com as medidas do triângulo X: ");
            //xA = double.Parse(Console.ReadLine());
            //xB = double.Parse(Console.ReadLine());
            //xC = double.Parse(Console.ReadLine());

            //Console.WriteLine("Entre com as medidas do triângulo Y: ");
            //yA = double.Parse(Console.ReadLine());
            //yB = double.Parse(Console.ReadLine());
            //yC = double.Parse(Console.ReadLine());

            //double p = (xA + xB + xC) / 2.0;
            //double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            //p = (yA + yB + yC) / 2.0;
            //double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            //Console.WriteLine($"Área de X = {areaX:F4}");
            //Console.WriteLine($"Área de Y = {areaY:F4}");

            //if (areaX > areaY)
            //{
            //    Console.WriteLine("Maior área: X");
            //}
            //else
            //{
            //    Console.WriteLine("Maior área: Y");
            //}
        }
    }
}
