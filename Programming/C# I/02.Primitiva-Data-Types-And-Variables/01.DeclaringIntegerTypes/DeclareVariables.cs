namespace DeclareVariables
{
    using System;

    /// <summary>
    /// Problem 1. Declare Variables
    /// Declare five variables choosing for each of them the most appropriate of the types 
    /// byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
    /// Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
    /// Submit the source code of your Visual Studio project as part of your homework submission.
    /// </summary>
    public class DeclareVariables
    {
       public static void Main()
        {
            ushort var1 = 52130;
            sbyte var2 = -115;
            int var3 = 4825932;
            sbyte var4 = 97;
            short var5 = -10000;
            Console.WriteLine("{0},{1},{2},{3},{4}", var1, var2, var3, var4, var5);
        }
    }
}
