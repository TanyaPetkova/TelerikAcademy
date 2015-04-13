namespace _17.MaxLength
{
    using System;
    using System.Linq;

    class MaxLength
    {
        static void Main()
        {
            byte arrayLength;

            Console.Write("Enter the array's length: ");

            while (!byte.TryParse(Console.ReadLine(), out arrayLength))
            {
                Console.Write("Invalid input. Enter a positive integer number: ");
            }

            string[] strings = new string[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("Enter the {0} element of the array: ", i);
                strings[i] = Console.ReadLine();
            }

            //using LINQ query
            var query =
                from element in strings
                orderby element.Length descending
                select element;

            Console.WriteLine(query.First());

            //using lamba expression
            //First variant
            Console.WriteLine(strings.OrderByDescending(x => x.Length).First());
            //Second variant
            Console.WriteLine(strings.Where(x => x.Length == strings.Max(y => y.Length)).First());
            //Third variant
            Console.WriteLine(strings.Aggregate("", (max, current) => max.Length > current.Length ? max : current));          
        }
    }
}
