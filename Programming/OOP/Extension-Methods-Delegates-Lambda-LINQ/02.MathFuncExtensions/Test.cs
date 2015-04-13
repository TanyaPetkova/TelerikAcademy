namespace _02.MathFuncExtensions
{
    using System;
    using System.Collections.Generic;

    class Test
    {  
        static void Main()
        {
            List<int> listOfInts = new List<int>();

            listOfInts.Add(1);
            listOfInts.Add(2);
            listOfInts.Add(3);

            Console.WriteLine(string.Join(", ", listOfInts));
            Console.WriteLine("Sum: {0}", listOfInts.Sum());
            Console.WriteLine("Product: {0}", listOfInts.Product());
            Console.WriteLine("Min: {0}", listOfInts.Min());
            Console.WriteLine("Max: {0}", listOfInts.Max());
            Console.WriteLine("Average: {0}", listOfInts.Average());
            Console.WriteLine("Count: {0}", listOfInts.Count());
        }
    }
}
