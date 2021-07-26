using InheritXFulfillContract.Models.Enums;

namespace InheritXFulfillContract.Models.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color color { get; set; }

        public abstract double Area();
    }
}
