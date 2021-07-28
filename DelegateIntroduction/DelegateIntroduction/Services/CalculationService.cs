﻿using System;

namespace DelegateIntroduction.Services
{
    class CalculationService
    {
        public static double Max(double x, double y)
        {
            return (x > y) ? x: y;
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
