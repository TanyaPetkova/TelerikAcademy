namespace RepetitionsExtractor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Write a program that extracts from a given sequence of strings all elements that present in it odd number of times. Example:
    /// {C#, SQL, PHP, PHP, SQL, SQL } -> {C#, SQL}
    /// </summary>
    public class Program
    {
        private const string InputMessage = "Enter a string or empty line for quitting";

        public static void Main()
        {
            Console.WriteLine(InputMessage);
            List<string> elements = new List<string>();

            while (true)
            {
                string currentLine = Console.ReadLine();

                if (string.IsNullOrEmpty(currentLine))
                {
                    break;
                }

                elements.Add(currentLine);
            }

            IDictionary<string, int> occurances = new Dictionary<string, int>();
            occurances = CountOddOccucarnces(elements, occurances);
            PrintDictionary(occurances);
        }

        public static IDictionary<string, int> CountOddOccucarnces(ICollection<string> array, IDictionary<string, int> occurancesCount)
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

            for (int i = 0; i < occurancesCount.Count; i++)
            {
                if (occurancesCount[occurancesCount.ElementAt(i).Key] % 2 == 0)
                {
                    occurancesCount.Remove(occurancesCount.ElementAt(i).Key);
                }
            }

            return occurancesCount;
        }

        public static void PrintDictionary(IDictionary<string, int> dict)
        {
            foreach (var element in dict)
            {
                Console.WriteLine("{0} -> {1} times", element.Key, element.Value);
            }
        }
    }
}
