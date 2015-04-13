namespace Shapes
{
    using System;

    public class Circle : Shape
    {
        private const double PI = Math.PI;

        public Circle(double diameter)
            : base(diameter, diameter)
        {
        }

        public override double CalculateSurface()
        {
            return PI * this.Width * this.Height / 4;
        }
    }
}
