namespace _03.RangeException
{
    using System;

    class Test
    {
        static void ReadNumber(int start, int end)
        {
            int number = 0;

            try
            {
                Console.Write("Enter a number in the range [{0}, {1}]: ", start, end);
                number = int.Parse(Console.ReadLine());

                if (number < start || number > end)
                {
                    throw new InvalidRangeException<int>(start, end);
                }
            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine("Invalid number. {0}", ex.Message);
            }
        }

        static void ReadDate(DateTime start, DateTime end)
        {
            DateTime date = new DateTime();

            try
            {
                Console.Write("Enter a date in the range [{0}, {1}]: ", start, end);
                date = DateTime.Parse(Console.ReadLine());

                if (date < start || date > end)
                {
                    throw new InvalidRangeException<DateTime>(start, end);
                }
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine("Invalid date. {0}", ex.Message);
            }   
        }

        static void Main()
        {
            ReadNumber(1, 100);

            DateTime startDate = new DateTime(1980, 1, 1);
            DateTime endDate = new DateTime(2013, 12, 31);
            ReadDate(startDate, endDate);        
        }
    }
}
