using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqIntroduction
{
    class Program
    {
        static void Main(string[] args)
        {
            // Specify the date source
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Define the query expression
            IEnumerable<int> result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

            // Execute the query
            foreach(int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
