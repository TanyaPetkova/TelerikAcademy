//Create a program that assigns null values to an integer and to double variables.
//Try to print them on the console, try to add some values or the null literal to them and see the result.

using System;

class NullableTypes
{
    static void Main()
    {
        int? someInteger = null;
        double? someDouble = null;

        Console.WriteLine("This is an integer variable with Null value ->", someInteger);
        Console.WriteLine("This is a double variable with Null value ->", someDouble);

        someInteger = someInteger + null;
        someDouble = someDouble + null;

        Console.WriteLine("This is an integer variable with value = null + null ->", someInteger);
        Console.WriteLine("This is a double variable with value = null + null ->", someDouble);

        someInteger+=5;
        someDouble+=5;

        Console.WriteLine("This is an integer variable with Null value + 5->", someInteger);
        Console.WriteLine("This is a double variable with Null value + 5->", someDouble);
    }
}

