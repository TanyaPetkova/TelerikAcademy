//Find online more information about ASCII (American Standard Code for Information Interchange)
//and write a program that prints the entire ASCII table of characters on the console.

using System;
using System.Text;

class ASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.Write("Decimal".PadRight(10));
        Console.Write("ASCII".PadRight(10));
        Console.WriteLine();

        int min = 0;
        int max = 256;
        for (int i = min; i < max; i++)
        {
            char c = (char)i;
            string display;

            if (char.IsWhiteSpace(c))
            {
                display = c.ToString();
                switch (c)
                {
                    case '\t':
                        display = "\\t";
                        break;
                    case ' ':
                        display = "space";
                        break;
                    case '\n':
                        display = "\\n";
                        break;
                    case '\r':
                        display = "\\r";
                        break;
                    case '\v':
                        display = "\\v";
                        break;
                    case '\f':
                        display = "\\f";
                        break;
                }
            }
            else
            {
                display = c.ToString();
            }

            Console.Write(i.ToString().PadRight(10));
            Console.Write(display.PadRight(10));
            Console.WriteLine();
        }
    }
}


