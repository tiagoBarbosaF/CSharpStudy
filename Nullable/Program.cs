using System;

namespace Nullable
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //double x = null;   erro

            //Nullable<double> x = null; Modo padrão de escrita
            double? x = null;  // Modo recomendado de escrita no Nullable
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X is null");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y is null");
            }

            // Operador de coalescencia nula
            Console.WriteLine("---------------------");
            double? a = null;
            double? b = 10;

            double c = a ?? 5;
            double d = b ?? 5;

            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}
