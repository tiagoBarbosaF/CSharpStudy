using System;
using System.Collections.Generic;
using FixationExercise04.Entities;

namespace FixationExercise04
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.WriteLine("=== Employess Payments ===");
            Console.Write("\nEnter the number of Employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nEmployee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hours: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("=====================================");
            Console.WriteLine("\n-- PAYMENTS --");
            foreach (Employee emp in list)
            {
                Console.WriteLine($"{emp.Name} - $ {emp.Payment():F2}");
            }
        }
    }
}
