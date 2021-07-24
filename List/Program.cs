using System;
using System.Collections.Generic;

namespace List
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");

            Console.WriteLine("Lista de pessoas: ");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
            Console.WriteLine($"List count: {list.Count}");

            Console.WriteLine();
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine($"List Find - First 'A': {s1}");

            Console.WriteLine();
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine($"List FindLast - First 'A': {s2}");

            Console.WriteLine();
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine($"List FindIndex - First position 'A': {pos1}");

            Console.WriteLine();
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine($"List FindLasIndex - Last position 'A': {pos2}");

            Console.WriteLine();
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("List FindAll:");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
            list.Remove("Alex");
            Console.WriteLine("List Remove: ");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("List RemoveAll: ");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
