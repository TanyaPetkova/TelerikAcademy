namespace CombinationsWithDuplicatesGenerator
{
    using System;

    public class Program
    {
        public const string SetLengthInputMessage = "Enter a positive integer number for the set length:";
        public const string ElementsCountInputMessage = "Enter a positive integer number for the elementsCount:";

        public static void Main()
        {
            int elementsCount = InputData(ElementsCountInputMessage);
            int setLength = InputData(SetLengthInputMessage);

            GenerateCombinations(elementsCount, 0, 0, new int[setLength]);
        }

        public static void GenerateCombinations(int elementsCount, int currentIndex, int startIndex, int[] vector)
        {
            if (currentIndex >= vector.Length)
            {
                Print(vector);
            }
            else
            {
                for (int i = startIndex; i < elementsCount; i++)
                {
                    vector[currentIndex] = i + 1;
                    GenerateCombinations(elementsCount, currentIndex + 1, i, vector);
                }
            }
        }

        public static int InputData(string inputMessage)
        {
            Console.WriteLine(inputMessage);
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine(inputMessage);
            }

            return n;
        }

        public static void Print(int[] vector)
        {
            Console.WriteLine("(" + string.Join(" ", vector) + ")");
        }
    }
}
