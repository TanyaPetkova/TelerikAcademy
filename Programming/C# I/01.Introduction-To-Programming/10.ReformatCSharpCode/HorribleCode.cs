namespace ReformatCSharpCode
{
    using System;

    /// <summary>
    /// Problem 10. Reformat C# Code
    /// Reformat the following C# code to make it readable according to the C# best practices for code formatting. 
    /// Change the casing of the identifiers in the code (e.g. use PascalCase for the class name): HorribleCode.cs
    /// </summary>
    public class HorribleCode
    {
        public const string GreetingMessage = "Hi, I am horribly formatted program\nNumbers and squares:";
        public const string FormattingArrow = " --> ";
        public const int NumbersCount = 10;

        public static void Main()
        {
            Console.WriteLine(GreetingMessage);
            for (int number = 0; number < NumbersCount; number++)
            {
                var square = number * number;
                Console.WriteLine(number + FormattingArrow + square);
            }
        }
    }
}