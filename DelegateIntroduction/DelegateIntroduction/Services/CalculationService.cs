using System;

namespace DelegateIntroduction.Services
{
    class CalculationService
    {

        public static void ShowMax(double x, double y)
        {
            double max = (x > y) ? x : y;
            Console.WriteLine($"ShowMax => {max}");
        }

        public static void ShowSum(double x, double y)
        {
            double sum = x + y;
            Console.WriteLine($"ShowSum => {sum}");
        }
        public static double Max(double x, double y)
        {
            return (x > y) ? x : y;
        }

        public static double Sum(double x, double y)
        {
            return x + y;
        }

        public static double Square(double x)
        {
            return Math.Pow(x, 2);
        }
    }
}
