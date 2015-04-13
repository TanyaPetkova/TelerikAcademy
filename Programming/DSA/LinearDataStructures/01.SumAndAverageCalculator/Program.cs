namespace SumAndAverageCalculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Write a program that reads from the console a sequence of positive integer numbers. 
    /// The sequence ends when empty line is entered. 
    /// Calculate and print the sum and average of the elements of the sequence. 
    /// Keep the sequence in List<int>.
    /// </summary>
    public class Program
    {
        private const string InputMessage = "Enter a positive integer number or empty line for quitting";

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

                if (!IsValidated(currentLine))
                {
                    Console.WriteLine(InputMessage);
                    continue;
                }

                var number = int.Parse(currentLine);
                numbers.Add(number);
            }

            Console.WriteLine(string.Join(", ", numbers));

            int sum = CalcSum(numbers);
            double average = CalcAverage(numbers);

            Console.WriteLine("The sum of the elements is: {0}", +sum);
            Console.WriteLine("The average of the elements is: {0}", +average);
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

        private static int CalcSum(List<int> numbers)
        {
            return numbers.Sum();
        }

        private static double CalcAverage(List<int> numbers)
        {
            return numbers.Average();
        }
    }
}
