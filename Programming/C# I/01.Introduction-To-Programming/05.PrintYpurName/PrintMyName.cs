﻿namespace PrintMyName
{
    using System;

    /// <summary>
    /// Problem 5. Print Your Name
    /// Modify the previous application to print your name.
    /// Ensure you have named the application well (e.g. “PrintMyName”).
    /// You should submit a separate project Visual Studio project holding the PrintMyName class as part of your homework.
    /// </summary>
    public class PrintMyName
    {
        public const string Name = "Tanya";

        public static void Main()
        {
            Console.WriteLine("My name is {0}", Name);
        }
    }
}