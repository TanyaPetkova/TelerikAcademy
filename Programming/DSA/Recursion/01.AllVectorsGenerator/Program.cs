namespace AllVectorsGenerator
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

            GenerateVector(0, new int[n]);
        }

        public static void GenerateVector(int index, int[] vector)
        {
            if (index >= vector.Length)
            {
                Print(vector);
            }
            else
            {
                for (int i = 0; i < vector.Length; i++)
                {
                    vector[index] = i + 1;
                    GenerateVector(index + 1, vector);
                }
            }
        }

        public static void Print(int[] vector)
        {
            Console.WriteLine(string.Join(" ", vector));
        }
    }
}
