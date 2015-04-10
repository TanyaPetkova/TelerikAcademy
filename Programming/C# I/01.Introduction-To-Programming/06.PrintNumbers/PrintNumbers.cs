namespace PrintNumbers
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Problem 6. Print Numbers
    /// Write a program to print the numbers 1, 101 and 1001, each at a separate line.
    /// Name the program correctly.
    /// You should submit in your homework the Visual Studio project holding the source code of the PrintNumbers program.
    /// </summary>
    public class PrintNumbers
    {
        public const int One = 1;
        public const int OneHundredAndOne = 101;
        public const int ThousandAndOne = 1001;

        public static void Main()
        {
            var numbers = new List<int>() { One, OneHundredAndOne, ThousandAndOne };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
