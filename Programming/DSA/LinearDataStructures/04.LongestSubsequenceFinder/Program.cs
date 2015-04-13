namespace LongestSubsequenceFinder
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Write a method that finds the longest subsequence of equal numbers in given List<int> 
    /// and returns the result as new List<int>. 
    /// Write a program to test whether the method works correctly.
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

            List<List<int>> result = FindLongestSubsequences(numbers);
            foreach (var list in result)
            {
                Console.WriteLine(string.Join(",", list));
            }
        }

        private static bool IsParsed(string input)
        {
            int number;
            bool isParsed = int.TryParse(input, out number);
            return isParsed;
        }

        public static List<List<int>> FindLongestSubsequences(List<int> sequence)
        {
            int currentLength = 1;
            int maxLength = 0;
            List<int> elements = new List<int>();

            int pointer = sequence[0];

            for (int i = 1; i < sequence.Count; i++)
            {
                if (pointer == sequence[i])
                {
                    currentLength++;
                }
                else
                {
                    pointer = sequence[i];

                    if (maxLength < currentLength)
                    {
                        maxLength = currentLength;
                        elements.Clear();
                        elements.Add(sequence[i - 1]);
                    }
                    else if (maxLength == currentLength)
                    {
                        elements.Add(sequence[i - 1]);
                    }

                    currentLength = 1;
                }
            }

            if (maxLength < currentLength)
            {
                maxLength = currentLength;
                elements.Clear();
                elements.Add(sequence[sequence.Count - 1]);
            }
            else if (maxLength == currentLength)
            {
                elements.Add(sequence[sequence.Count - 1]);
            }

            elements.Add(maxLength);

            List<List<int>> allMaxSequences = GetAllMaxSequences(elements);
            return allMaxSequences;
        }

        private static List<List<int>> GetAllMaxSequences(List<int> sequence)
        {
            int maxLength = sequence[sequence.Count - 1];
            sequence.RemoveAt(sequence.Count - 1);

            if (sequence.Count == 1)
            {
                Console.Write("There is one sequence of equal elements with maximal length: ");
            }
            else
            {
                Console.WriteLine("There are {0} sequences of equal elements with maximal length: ", sequence.Count);
            }

            List<List<int>> maxSequences = new List<List<int>>();

            foreach (var element in sequence)
            {
                List<int> maxSequence = new List<int>();

                for (int i = 0; i < maxLength; i++)
                {
                    maxSequence.Add(element);
                }

                maxSequences.Add(maxSequence);
            }

            return maxSequences;
        }
    }
}
