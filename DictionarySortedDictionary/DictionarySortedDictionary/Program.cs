using System;
using System.Collections.Generic;

namespace DictionarySortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "tiago";
            cookies["email"] = "tiago@gmail.com";
            cookies["phone"] = "9988445566";
            cookies["phone"] = "9951684457";

            Console.WriteLine(cookies["email"]);

            cookies.Remove("email");

            Console.WriteLine($"Phone number: {cookies["phone"]}");

            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine($"E-mail: {cookies["email"]}");
            }
            else
            {
                Console.WriteLine("There is not 'email' key");
            }

            Console.WriteLine($"Size: {cookies.Count}");

            Console.WriteLine();
            Console.WriteLine("ALL COOKIES:");
            foreach(KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}
