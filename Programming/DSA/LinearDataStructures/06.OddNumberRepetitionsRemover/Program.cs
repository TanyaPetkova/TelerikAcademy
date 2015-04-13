namespace _06.OddNumberRepetitionsRemover
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Write a program that removes from given sequence all numbers that occur odd number of times.
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

            RemoveAllOddNumberRepetitions(numbers);
            Console.WriteLine(string.Join(", ", numbers));
        }

        private static bool IsParsed(string input)
        {
            int number;
            bool isParsed = int.TryParse(input, out number);
            return isParsed;
        }

        public static void RemoveAllOddNumberRepetitions(List<int> sequence)
        {
            List<int> matchedCodition = sequence.FindAll(num => sequence.Count(x => x == num) % 2 != 0);
            sequence.RemoveAll(x => matchedCodition.Contains(x));
        }
    }
}
