using System;
using System.Collections.Generic;

namespace HashSetSortedSetPart02
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 9, 10, 12 };
            SortedSet<int> b = new SortedSet<int>() { 6, 8, 4, 9, 15, 32, 44 };

            // union
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            Console.WriteLine("Union: ");
            PrintCollection(c);
            Console.WriteLine();

            // intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            Console.WriteLine("Intersection: ");
            PrintCollection(d);
            Console.WriteLine();

            // difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            Console.WriteLine("Difference: ");
            PrintCollection(e);
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach(T obj in collection)
            {
                Console.Write($"{obj} ");
            }
            Console.WriteLine();
        }
    }
}
