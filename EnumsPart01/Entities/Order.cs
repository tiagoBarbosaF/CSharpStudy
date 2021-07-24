using System;
using EnumsPart01.Entities.Enums;

namespace EnumsPart01.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Date Order: {Moment}, Status: {Status}";
        }
    }
}
