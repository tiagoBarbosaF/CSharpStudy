using System;
using System.IO;
using System.Collections.Generic;
using InterfaceIComparable.Entities;

namespace InterfaceIComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            //string path = @"C:\Users\antonio.farias\Documents\Tiago GitHub\CSharpStudy\CSharpStudy\FilesTest\in.txt";
            string path = @"C:\Users\antonio.farias\Documents\Tiago GitHub\CSharpStudy\CSharpStudy\FilesTest\in2.txt";

            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();

                    foreach(Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }

            } catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
