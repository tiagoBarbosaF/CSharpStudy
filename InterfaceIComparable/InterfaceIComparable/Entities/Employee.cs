using System;
using System.Globalization;

namespace InterfaceIComparable.Entities
{
    class Employee : IComparable
    {
        public string name { get; set; }
        public double salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(',');
            name = vect[0];
            salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return $"Name: {name}, Salary: {salary.ToString("F2",CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Employee))
            {
                throw new ArgumentException("Comparing erros: argument is not valid.");
            }

            Employee other = obj as Employee;
            return name.CompareTo(other.name);
        }
    }
}
