namespace Shapes
{
    using System;

    class Test
    {
        static void Main()
        {
            Shape[] shapes = 
            {
                new Triangle(5, 5),
                new Rectangle(5, 5),
                new Circle(5)
            };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine("The shape {0} has a surface = {1:F2}.", shape.GetType().Name, shape.CalculateSurface());
            }
        }
    }
}
