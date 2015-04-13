namespace NegativeNumbersRemover
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Write a program that removes from given sequence all negative numbers.
    /// </summary>
    public class Program
    {
        private const string InputMessage = "Enter an integer number or empty line for quitting";

        public static void Main()
        {
            List<int> numbers = new List<int>();
            Console.WriteLine(InputMessage);

            while (true)
            {
                string currentLine = Console.ReadLine();

                if (string.IsNullOrEmpty(currentLine))
                {
                    break;
                }

                if (!IsParsed(currentLine))
                {
                    Console.WriteLine(InputMessage);
                    continue;
                }

                var number = int.Parse(currentLine);
                numbers.Add(number);
            }

            var result = RemoveNegativeNumbers(numbers);
            Console.WriteLine(string.Join(", ", result));
        }

        private static bool IsParsed(string input)
        {
            int number;
            bool isParsed = int.TryParse(input, out number);
            return isParsed;
        }

        public static List<int> RemoveNegativeNumbers(List<int> sequence)
        {
            sequence.RemoveAll(x => x < 0);
            return sequence;
        }
    }
}
