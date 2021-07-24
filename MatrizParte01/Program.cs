using System;

namespace MatrizParte01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double[,] mat = new double[2, 3];

            Console.WriteLine("Tamanho da matriz (Lenght):");
            Console.WriteLine(mat.Length);

            Console.WriteLine();
            Console.WriteLine("Quantidade de linhas (Rank):");
            Console.WriteLine(mat.Rank);

            Console.WriteLine();
            Console.WriteLine("Indica a quantidade de linhas da Matriz (GetLenght(0)):");
            Console.WriteLine(mat.GetLength(0));

            Console.WriteLine();
            Console.WriteLine("Indica a quantidade de colunas da Matriz (GetLenght(1))");
            Console.WriteLine(mat.GetLength(1));
        }
    }
}
