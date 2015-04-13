namespace _01.StringBuilderExtension
{
    using System;
    using System.Text;

    class Test
    {
        static void Main()
        {
            StringBuilder someString = new StringBuilder("someString");
            Console.WriteLine(someString.Substring(4, 6));
        }
    }
}
