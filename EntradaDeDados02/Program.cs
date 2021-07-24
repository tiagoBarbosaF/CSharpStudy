using System;

namespace EntradaDeDados02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double db = double.Parse(Console.ReadLine());
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int age = int.Parse(vet[2]);
            double height = double.Parse(vet[3]);

            Console.WriteLine("Você digitou:");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(db);
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(age);
            Console.WriteLine(height);
            Console.WriteLine($"{nome} de gênero {sexo} com idade de {age} e com altura de {height}.");
        }
    }
}
