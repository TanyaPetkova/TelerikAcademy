namespace AllPermutationsGenerator
{
    using System;

    public class Program
    {
        public const string InputMessage = "Enter a positive integer number:";

        public static void Main()
        {
            Console.WriteLine(InputMessage);
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine(InputMessage);
            }

            int[] initialVector = new int[n];
            for (int i = 0; i < n; i++)
            {
                initialVector[i] = i + 1;
            }

            GenerateVector(0, initialVector);
        }

        public static void GenerateVector(int index, int[] vector)
        {
            if (index >= vector.Length - 1)
            {
                Print(vector);
            }
            else
            {
                for (int i = index; i < vector.Length; i++)
                {
                    Swap(ref vector[index], ref vector[i]);
                    GenerateVector(index + 1, vector);
                    Swap(ref vector[index], ref vector[i]);
                }
            }
        }

        private static void Swap(ref int first, ref int second)
        {
            var swapValue = first;
            first = second;
            second = swapValue;
        }

        public static void Print(int[] vector)
        {
            Console.WriteLine(string.Format("{{{0}}}", string.Join(",", vector)));
        }
    }
}
