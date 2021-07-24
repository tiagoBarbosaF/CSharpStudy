﻿using System;

namespace StaticMembers01
{
    public class Calculadora
    {
        public static double Pi = 3.14;

        public static double Circuferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        public static double Volume(double v)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(v, 3.0);
        }
    }
}
