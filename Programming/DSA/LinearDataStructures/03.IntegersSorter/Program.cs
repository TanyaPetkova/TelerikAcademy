namespace IntegersSorter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Write a program that reads a sequence of integers (List<int>) 
    /// ending with an empty line and sorts them in an increasing order.
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

            // Print sequence
            Console.WriteLine(string.Join(", ", numbers));

            numbers.Sort();

            // Print sorted sequence
            Console.WriteLine(string.Join(", ", numbers));
        }

        private static bool IsParsed(string input)
        {
            int number;
            bool isParsed = int.TryParse(input, out number);
            return isParsed;
        }
    }
}
