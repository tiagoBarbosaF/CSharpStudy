using System;

namespace ArraysPart02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Quantidade de produtos que quer inserir no estoque: ");
            int n = int.Parse(Console.ReadLine());

            Product[] arr = new Product[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Descrição do produto #{i + 1}: ");
                string name = Console.ReadLine();
                Console.Write($"Valor do produto #{i + 1}: ");
                double price = double.Parse(Console.ReadLine());
                arr[i] = new Product(name, price);
            }

            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += arr[i].Price;
            }

            Console.WriteLine();
            double avg = sum / n;
            Console.WriteLine($"Average price: {avg:F2}");
        }
    }
}
