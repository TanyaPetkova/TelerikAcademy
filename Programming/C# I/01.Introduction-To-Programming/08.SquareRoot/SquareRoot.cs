namespace SquareRoot
{
    using System;

    /// <summary>
    /// Problem 8. Square Root
    /// Create a console application that calculates and prints the square root of the number 12345.
    /// Find in Internet “how to calculate square root in C#”.
    /// </summary>
    public class SquareRoot
    {
        public const int Number = 12345;

        public static void Main()
        {
            var squareRoot = CalculateSquareRoot(Number);
            PrintNumber(squareRoot);
        }

        private static double CalculateSquareRoot(int number) 
        {
            var squareRoot = Math.Sqrt(number);
            return squareRoot;
        }

        private static void PrintNumber(double number)
        {
            Console.WriteLine(number);
        }
    }
}
