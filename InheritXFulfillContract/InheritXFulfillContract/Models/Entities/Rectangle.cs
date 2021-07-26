using System.Globalization;

namespace InheritXFulfillContract.Models.Entities
{
    class Rectangle : AbstractShape
    {
        public double width { get; set; }
        public double height { get; set; }

        public override double Area()
        {
            return width * height;
        }

        public override string ToString()
        {
            return $"Rectangle: " +
                   $"\nColor = {color}, Width = {width.ToString("F2", CultureInfo.InvariantCulture)}, " +
                   $"Height = {height.ToString("F2", CultureInfo.InvariantCulture)}, " +
                   $"Area = {Area().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
