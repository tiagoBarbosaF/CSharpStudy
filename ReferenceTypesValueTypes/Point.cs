using System;
namespace ReferenceTypesValueTypes
{
    public struct Point
    {
        public double x, y;

        public override string ToString()
        {
            return $"( {x}, {y} )";
        }
    }
}
