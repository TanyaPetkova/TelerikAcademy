//Write a program that safely compares floating-point numbers with precision of 0.000001. 
//Examples: (5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true

using System;

class CompareNumbers
{
    static void Main()
    {
        Console.Write("Enter the first number to compare: ");
        float number1;

        while (!float.TryParse(Console.ReadLine(), out number1))
        {
            Console.WriteLine("Invalid input. Enter a number: ");
        }

        Console.Write("Enter the second number to compare: ");
        float number2;

        while (!float.TryParse(Console.ReadLine(), out number2))
        {
            Console.WriteLine("Invalid input. Enter a number: ");
        }

        if (number1 == number2)
	    {
		    Console.WriteLine("The compared numbers are equal.");
	    }
        else
	    {
            Console.WriteLine("The compared numbers are not equal.");
	    }
    }
}

