using System;
using System.Globalization;

namespace InheritXFulfillContract.Models.Entities
{
    class Circle : AbstractShape
    {
        public double radius { get; set; }

        public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override string ToString()
        {
            return $"Circle: " +
                   $"\nColor = {color}, Radius = {radius.ToString("F2", CultureInfo.InvariantCulture)}" +
                   $", Area = {Area().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
