using System;

namespace FixationExercise02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string name = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int rooms = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double price = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu sobrenome, idade e altura (mesma linha):");
            string[] vet = Console.ReadLine().Split(',');

            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine("Cadastro:");
            Console.WriteLine($"Nome -> {name}");
            Console.WriteLine($"Quantidade de quartos -> {rooms}");
            Console.WriteLine($"Preço de um produto -> {price}");
            Console.WriteLine($"Sobrenome -> {vet[0]}, Idade -> {vet[1]}, Altura -> {vet[2]}.");
        }
    }
}
