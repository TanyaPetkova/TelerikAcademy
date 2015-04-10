namespace PrintLongSequence
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Problem 16.* Print Long Sequence
    /// Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
    /// You might need to learn how to use loops in C# (search in Internet)
    /// </summary>
    public class PrintLongSequence
    {
        public const int MembersCount = 1000;
        public const int FirstMember = 2;

        public static void Main()
        {
            var sequence = new List<int>();

            sequence = GenerateSequence(FirstMember);
            PrintSequence(sequence);
        }

        private static List<int> GenerateSequence(int firstMember)
        {
            var sequence = new List<int>() { firstMember };
            var currentMember = firstMember;

            for (int i = 0; i < MembersCount; i++)
            {
                currentMember = (Math.Abs(currentMember) + 1) * Math.Sign(currentMember) * (-1);
                sequence.Add(currentMember);
            }

            return sequence;
        }

        private static void PrintSequence(List<int> sequence)
        {
            Console.WriteLine(string.Join(", ", sequence));
        }
    }
}
