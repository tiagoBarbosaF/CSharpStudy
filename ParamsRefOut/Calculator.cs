namespace ParamsRefOut
{
    public class Calculator
    {
        public static void TripleRef(ref double x)
        {
            x *= 3;
        }

        public static void TripleOut(double origin, out double result)
        {
            result = origin * 3;
        }
    }
}
