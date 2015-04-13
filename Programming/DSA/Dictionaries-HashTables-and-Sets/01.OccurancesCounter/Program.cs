namespace OccurancesCounter
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /*Write a program that counts in a given array of double values the number of occurrences of each value. Use Dictionary<TKey,TValue>.
        Example: array = {3, 4, 4, -2.5, 3, 3, 4, 3, -2.5}
        -2.5 -> 2 times
        3 -> 4 times
        4 -> 3 times*/
    /// </summary>
    public class Program
    {
        private const string InputMessage = "Enter a number or empty line for quitting";

        public static void Main()
        {
            Console.WriteLine(InputMessage);
            List<double> numbers = new List<double>();

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

                var number = double.Parse(currentLine);
                numbers.Add(number);
            }

            IDictionary<double, int> occurances = new SortedDictionary<double, int>();
            occurances = CountOccucarnces(numbers, occurances);
            PrintDictionary(occurances);
        }

        private static bool IsParsed(string input)
        {
            double number;
            bool isParsed = double.TryParse(input, out number);
            return isParsed;
        }

        public static IDictionary<double, int> CountOccucarnces(ICollection<double> array, IDictionary<double, int> occurancesCount)
        {            
            foreach (var element in array)
            {
                int count;
                if (!occurancesCount.TryGetValue(element, out count))
                {
                    count = 0;
                }

                occurancesCount[element] = ++count;
            }

            return occurancesCount;
        }

        public static void PrintDictionary(IDictionary<double, int> dict)
        {
            foreach (var element in dict)
            {
                Console.WriteLine("{0} -> {1} times", element.Key, element.Value);
            }
        }
    }
}
