//Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

using System;

class ExchangingValues
{
    static void Main()
    {
        int firstVariable = 5;
        int secondVariable = 10;
        int temp;

        Console.WriteLine("firstVariable = {0}, secondVariable = {1}", firstVariable, secondVariable );

        temp = firstVariable;
        firstVariable = secondVariable;
        secondVariable = temp;

        Console.WriteLine("firstVariable = {0}, secondVariable = {1}", firstVariable, secondVariable);
    }
}

