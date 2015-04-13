namespace QuotesInStrings
{
    using System;

    /// <summary>
    /// Problem 7. Quotes in Strings
    /// Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
    /// Do the above in two different ways - with and without using quoted strings.
    /// Print the variables to ensure that their value was correctly defined.
    /// </summary>
    public class QuotesInStrings
    {
        public static void Main()
        {
            string quotedString = "The \"use\" of quotations causes difficulties.";
            Console.WriteLine(quotedString);

            string quotedStringWithAt = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(quotedStringWithAt);       
        }
    }
}
