namespace OccurancesCalculator
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Write a program that finds in given array of integers (all belonging to the range [0..1000]) 
    /// how many times each of them occurs.
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

            SortedDictionary<int, int> occurances = FindAllOccurances(numbers);
            PrintDictionary(occurances);
        }

        private static bool IsInRange(string input)
        {
            bool isInRange = true;

            if (int.Parse(input) < 0 || int.Parse(input) > 1000)
            {
                isInRange = false;
            }

            return isInRange;
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

            if (IsParsed(input) && IsInRange(input))
            {
                isValidated = true;
            }

            return isValidated;
        }

        public static SortedDictionary<int, int> FindAllOccurances(List<int> numbers)
        {
            SortedDictionary<int, int> occurances = new SortedDictionary<int, int>();

            foreach (int number in numbers)
            {
                int occurance;

                if (!occurances.TryGetValue(number, out occurance))
                {
                    occurance = 0;
                }

                occurances[number] = ++occurance;
            }

            return occurances;
        }

        public static void PrintDictionary(IDictionary<int, int> dict)
        {
            foreach (var element in dict)
            {
                Console.WriteLine("{0} -> {1} times", element.Key, element.Value);
            }
        }
    }
}
