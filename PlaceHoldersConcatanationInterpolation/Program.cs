using System;
using System.Globalization;

namespace PlaceHoldersConcatanationInterpolation
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int age = 32;
            double balance = 10.35784;
            String name = "Tiago";

            //Placeholder
            Console.WriteLine("{0} tem {1} ano e tem saldo igual a {2:F2} reais", name, age, balance);

            //Interpolation
            Console.WriteLine($"{name} tem {age} anos e tem saldo igual a {balance:F2} reais");

            //Concatanation
            Console.WriteLine(name + " tem " + age + " anos e tem saldo igual a "
                              + balance.ToString("F2", CultureInfo.InvariantCulture) + " reais");
        }
    }
}
