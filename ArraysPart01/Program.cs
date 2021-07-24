using System;

namespace ArraysPart01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Quantidade de Dados a receber: ");
            int n = int.Parse(Console.ReadLine());

            double[] arr = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Altura #{i + 1}: ");
                arr[i] = double.Parse(Console.ReadLine());
            }

            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }

            double avg = sum / n;

            Console.WriteLine($"Average height: {avg:F2}");
        }
    }
}
