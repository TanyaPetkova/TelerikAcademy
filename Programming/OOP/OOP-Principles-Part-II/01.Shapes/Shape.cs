namespace Shapes
{
    public abstract class Shape
    {
        public double Width { get; private set; }
        public double Height { get; private set; }

        public Shape(double width, double heigth)
        {
            this.Width = width;
            this.Height = heigth;
        }

        public abstract double CalculateSurface();
    }
}
