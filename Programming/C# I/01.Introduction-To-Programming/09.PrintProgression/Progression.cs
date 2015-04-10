//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

using System;

class Progression
{
    static void Main()
    {
        short counter = 0;
        short term = 2;
        while (counter<10)
        {
            if (term % 2 == 0)
            {
                Console.Write(term + ", ");
            }
            else
            {
                Console.Write(-term + ", ");
            }
            term++;
            counter++;
        }
        Console.Write("\b" + "\b" + " ");
        Console.WriteLine();
    }
}

