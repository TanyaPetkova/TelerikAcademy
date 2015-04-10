namespace PrintASequence
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Problem 9. Print a Sequence
    /// Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
    /// </summary>
    public class PrintASequence
    {
        public const int MembersCount = 10;
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
