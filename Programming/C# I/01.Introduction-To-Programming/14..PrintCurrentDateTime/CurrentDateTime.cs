namespace CurrentDateTime
{
    using System;

    /// <summary>
    /// Create a console application that prints the current date and time. Find out how in Internet.
    /// </summary>
    public class CurrentDateTime
    {
        public static void Main()
        {
            var currentDateAndTime = DateTime.Now;
            Console.WriteLine(currentDateAndTime);
        }
    }
}
