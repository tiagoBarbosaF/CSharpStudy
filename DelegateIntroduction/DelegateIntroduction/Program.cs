using System;
using DelegateIntroduction.Services;

namespace DelegateIntroduction
{
    delegate double BinaryNumericOperation(double n1, double n2);
    delegate double BinaryNumericOperation2(double n1);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op1 = CalculationService.Sum;
            BinaryNumericOperation op2 = CalculationService.Max;
            BinaryNumericOperation2 op3 = CalculationService.Square;

            double result1 = op1(a, b);
            double result2 = op2(a, b);
            double result3 = op3(a);

            Console.WriteLine($"Sum using delegate => {result1}");
            Console.WriteLine($"Max using delegate => {result2}");
            Console.WriteLine($"Square using delegate => {result3}");
        }
    }
}
