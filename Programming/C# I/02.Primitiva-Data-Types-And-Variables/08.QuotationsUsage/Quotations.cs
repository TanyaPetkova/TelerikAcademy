//Declare two string variables and assign them with following value:
//The "use" of quotations causes difficulties.
//Do the above in two different ways: with and without using quoted strings.

using System;

class Quotations
{
    static void Main()
    {
        string quote1 = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(quote1);

        string quote2 = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(quote2);       
    }
}

