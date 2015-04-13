using System;
using System.Linq;

class Division
{
    private const byte MagicNumber = 3 * 7;

    static void Main()
    {
        byte arrayLength;

        Console.Write("Enter the array's length: ");

        while (!byte.TryParse(Console.ReadLine(), out arrayLength))
        {
            Console.Write("Invalid input. Enter a positive integer number: ");
        }

        int[] numbers = new int[arrayLength];

        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("Enter the {0} element of the array: ", i);

            while (!int.TryParse(Console.ReadLine(), out numbers[i]))
            {
                Console.Write("Invalid input. Enter an integer number: ");
            }
        }

        Console.WriteLine("List of all numbers that are divisible by 7 and 3:");

        //using LINQ query
        var query =
            from number in numbers
            where number % MagicNumber == 0
            select number;

        Console.WriteLine(string.Join(", ", query));
     
        //using lamba expression
        Console.WriteLine(string.Join(", ", numbers.Where(x => x % MagicNumber == 0)));
    }
}

