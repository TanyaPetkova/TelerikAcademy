namespace SequencePrinter
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /* We are given the following sequence:
        S1 = N;
        S2 = S1 + 1;
        S3 = 2*S1 + 1;
        S4 = S1 + 2;
        S5 = S2 + 1;
        S6 = 2*S2 + 1;
        S7 = S2 + 2;
        ...
        Using the Queue<T> class write a program to print its first 50 members for given N.
        Example: N=2  2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ... */
    /// </summary>
    public class Program
    {
        private const string inputMessage = "Enter the first term of the sequence: ";

        public static void Main()
        {
            Console.WriteLine(inputMessage);
            string number = Console.ReadLine();
            while (!IsParsed(number))
            {
                Console.WriteLine(inputMessage);
                number = Console.ReadLine();
            }

            int firstTerm = int.Parse(number);
            int termsCount = 50;

            List<int> sequence = GenerateSequence(firstTerm, termsCount);
            sequence.RemoveRange(termsCount, sequence.Count - termsCount);

            Console.WriteLine("First term = {0}", firstTerm);
            Console.WriteLine("Terms count = {0}", termsCount);

            for (int i = 0; i < sequence.Count; i++)
            {
                int index = i + 1;
                Console.WriteLine("N" + index + ".  " +  sequence[i]);
            }
        }

        private static bool IsParsed(string input)
        {
            int number;
            bool isParsed = int.TryParse(input, out number);
            return isParsed;
        }

        public static List<int> GenerateSequence(int firstTerm, int termsCount)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(firstTerm);

            List<int> sequence = new List<int>() { firstTerm };

            while(sequence.Count < termsCount)
            {
                int current = queue.Dequeue();

                queue.Enqueue(current + 1);
                sequence.Add(current + 1);

                queue.Enqueue(2 * current + 1);
                sequence.Add(2 * current + 1);

                queue.Enqueue(current + 2);
                sequence.Add(current + 2);            
            }

            return sequence;
        }
    }
}
