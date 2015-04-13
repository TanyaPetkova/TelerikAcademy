namespace IntegersReverser
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Write a program that reads N integers from the console and reverses them 
    /// using a stack. Use the Stack<int> class.
    /// </summary>
    public class Program
    {
        private const string InputMessage = "Enter a positive integer number N: ";

        public static void Main()
        {
            Console.WriteLine(InputMessage);
            string currentLine = Console.ReadLine();

            while (!IsValidated(currentLine) || string.IsNullOrEmpty(currentLine))
            {
                Console.WriteLine(InputMessage);
                currentLine = Console.ReadLine();
            }

            int numbersCount = int.Parse(currentLine);
            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < numbersCount; i++)
            {
                currentLine = Console.ReadLine();
                while (!IsParsed(currentLine))
                {
                    currentLine = Console.ReadLine();
                }

                int currentNumber = int.Parse(currentLine);
                numbers.Push(currentNumber);
            }

            Console.WriteLine();
            Console.WriteLine(string.Join(", ", numbers));
        }

        private static bool IsPositiveNumber(string input)
        {
            bool isPositiveNumber = true;

            if (int.Parse(input) < 0)
            {
                isPositiveNumber = false;
            }

            return isPositiveNumber;
        }

        private static bool IsParsed(string input)
        {
            int number;
            bool isParsed = int.TryParse(input, out number);
            return isParsed;
        }

        private static bool IsValidated(string input)
        {
            bool isValidated = false;

            if (IsParsed(input) && IsPositiveNumber(input))
            {
                isValidated = true;
            }

            return isValidated;
        }
    }
}
