namespace AgeAfter10Years
{
    using System;
    using System.Globalization;

    /// <summary>
    /// Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
    /// </summary>
    public class AgeAfter10Years
    {
        public const string DateTimeInputFormat = "dd/mm/yyyy";
        public const string InputMessage = "Enter your birthday in the following format: ";
        public const string InvalidInputMessage = "Invalid input! Enter your birthday in the correct format.";
        public const int YearDistance = 10;

        public static void Main()
        {
           var birtdayDate = ReadBirthdayDate();
            PrintAgeAfterYearsDistance(birtdayDate);
        }
 
        private static DateTime ReadBirthdayDate()
        {
            Console.WriteLine(InputMessage + DateTimeInputFormat);
            var birthdayDate = new DateTime();
            while (!DateTime.TryParseExact(Console.ReadLine(), DateTimeInputFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out birthdayDate))
            {
                Console.WriteLine(InvalidInputMessage);
            }

            return birthdayDate;
        }

        private static void PrintAgeAfterYearsDistance(DateTime birthdayDate)
        {
            var currentAge = DateTime.Now.Year - birthdayDate.Year;
            var yearAgter10Years = DateTime.Now.Year + YearDistance;
            var ageAfter10Years = currentAge + YearDistance;
            Console.WriteLine("After 10 years in year {0} you will be {1} years old.", yearAgter10Years, ageAfter10Years);
        }
    }
}
