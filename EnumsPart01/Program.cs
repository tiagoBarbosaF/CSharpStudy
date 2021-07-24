using System;
using EnumsPart01.Entities;
using EnumsPart01.Entities.Enums;

namespace EnumsPart01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            Console.WriteLine();
            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");

            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}
