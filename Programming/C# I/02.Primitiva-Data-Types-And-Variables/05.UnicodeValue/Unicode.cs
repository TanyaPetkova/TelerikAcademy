//Declare a character variable and assign it with the symbol that has Unicode code 72. 
//Hint: first use the Windows Calculator to find the hexadecimal representation of 72.

using System;

class Unicode
{
    static void Main()
    {
        //First varint
        char unicode1 = '\u0048';
        Console.WriteLine("First varint:The symbol, that has Unicode code 72, is {0}", unicode1);

        //Second variant
        char unicode2 = (char)72;
        Console.WriteLine("Second Variant:The symbol, that has Unicode code 72, is {0}", unicode2);
    }
}

