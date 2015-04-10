//Write a program to read your age from the console and print how old you will be after 10 years.

using System;

class Age
{
    static void Main()
    {
        DateTime dateTime = new DateTime();
        dateTime = DateTime.Now;
        ushort year = (ushort)dateTime.Year;
        Console.Write("Enter your current age: "); 
        byte currentAge;
        while (!byte.TryParse(Console.ReadLine(), out currentAge) || (currentAge < 1 || currentAge > 120))
        {
           Console.Write("Invalid input. Enter your current age: ");
        }
        Console.WriteLine("After 10 years in year {0} you will be {1} years old.", year+10, currentAge + 10);
    }
}
