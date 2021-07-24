using System;

namespace ExpressaoCondicionalTernaria
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Write the product value: ");
            double price = double.Parse(Console.ReadLine());
            double discount = (price < 20) ? price * 0.05 : price * 0.1;

            Console.WriteLine($"Product value: {price} and Discount: {discount}");
        }
    }
}
