using System;

namespace StringFunctions
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG     ";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();
            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);
            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");

            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");

            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);

            Console.Write($"Original: -{original}-");
            Console.Write($"\nToUpper: -{s1}-");
            Console.Write($"\nToLower: -{s2}-");
            Console.Write($"\nTrim: -{s3}-");
            Console.Write($"\nSubstring( 3 ): -{s4}-");
            Console.Write($"\nSubstring( 3 , 5 ): -{s5}-");
            Console.Write($"\nReplace( a , x ): -{s6}-");
            Console.Write($"\nReplace( abc , xy ): -{s7}-");
            Console.Write($"\nIndexOf( bc ): {n1}");
            Console.Write($"\nLastIndexOf( bc ): {n2}");
            Console.Write($"\nIsNullOrEmpty: {b1}");
            Console.Write($"\nIsNullOrWhiteSpace: {b2}");
        }
    }
}
