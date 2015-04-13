namespace VariableInHexadecimalFormat
{
    using System;

    /// <summary>
    /// Problem 3. Variable in Hexadecimal Format
    /// Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).
    /// Use Windows Calculator to find its hexadecimal representation.
    /// Print the variable and ensure that the result is 254.
    /// </summary>
    public class VariableInHexadecimalFormat
    {
        public static void Main()
        {
            int hexNumber = 0xFE;
            Console.WriteLine("The hexadecimal value of the number {0} is {0:X}.", hexNumber);
        }
    }
}
