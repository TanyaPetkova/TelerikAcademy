namespace IsoscelesTriangle
{
    using System;
    using System.Text;

    /// <summary>
    /// Problem 8. Isosceles Triangle
    /// Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
    ///    ©
    ///   © ©
    ///  ©   ©
    /// © © © ©
    /// Note: The © symbol may be displayed incorrectly at the console so you may need to change 
    /// the console character encoding to UTF-8 and assign a Unicode-friendly font in the console.
    /// Note: Under old versions of Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.
    /// </summary>
    public class IsoscelesTriangle
    {
        public const char CopyrightSymbol = '\u00A9';
        public const char Space = ' ';
        public const int LineNumbers = 4;

        public static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            PrintTriangle(LineNumbers, CopyrightSymbol);
        }

        private static void PrintTriangle(int lineNumbers, char symbol)
        {
            StringBuilder triangle = new StringBuilder();

            // Construct the first line
            var offset = new string(Space, lineNumbers - 1);
            var firstLine = offset + symbol + offset;
            triangle.AppendLine(firstLine);

            // Construct the middle part
            for (int i = 0; i < lineNumbers - 2; i++)
            {
                offset = new string(Space, lineNumbers - 2 - i);
                var middleOffset = new string(Space, (i * 2) + 1);
                var currentLine = offset + symbol + middleOffset + symbol + offset;
                triangle.AppendLine(currentLine);
            }

            // Construct the last line
            var lastLine = new StringBuilder();
            for (int i = 1; i <= (lineNumbers * 2) - 1; i++)
            {
                if (i % 2 != 0)
                {
                    lastLine.Append(symbol);
                }
                else
                {
                    lastLine.Append(Space);
                }
            }

            triangle.Append(lastLine.ToString());
            Console.WriteLine(triangle.ToString());
        }
    }
}
