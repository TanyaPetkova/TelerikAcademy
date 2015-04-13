namespace MessagesInABottle
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Program
    {
        static string message = Console.ReadLine();
        static Dictionary<char, string> dict = new Dictionary<char, string>();
        static SortedSet<string> solutions = new SortedSet<string>();

        public static void Main()
        {
            string chipher = Console.ReadLine();
            char[] numbers = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            string[] chipherLetters = chipher.Split(numbers, StringSplitOptions.RemoveEmptyEntries);
            char[] letters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            string[] chipherNumbers = chipher.Split(letters, StringSplitOptions.RemoveEmptyEntries);          
            for (int i = 0; i < chipherLetters.Length; i++)
            {
                dict[chipherLetters[i][0]] = chipherNumbers[i];
            }

            Solve(0, new StringBuilder());
            Console.WriteLine(solutions.Count);
            foreach (var solution in solutions)
            {
                Console.WriteLine(solution);
            }
        }

        static void Solve(int secretMessageIndex, StringBuilder sb)
        {
            if (secretMessageIndex == message.Length)
            {
                solutions.Add(sb.ToString());
                return;
            }

            foreach (var chipher in dict)
            {
                if (message.Substring(secretMessageIndex).StartsWith(chipher.Value))
                {
                    sb.Append(chipher.Key);
                    Solve(secretMessageIndex + chipher.Value.Length, sb);
                    sb.Length--;
                }
            }
        }
    }
}
