namespace Mobile
{
    using System;
    using System.Linq;

    class GSMCallHistoryTest
    {
        private const double PricePerMinute = 0.37;

        public static void Test()
        {
            //Create an instance of the GSM class
            GSM gsm = new GSM("Iphone 5S", "Apple");

            //Add few calls
            gsm.AddCall(new Call(new DateTime(2014, 1, 2, 12, 24, 0), "0889333333", 78));
            gsm.AddCall(new Call(new DateTime(2014, 2, 2, 18, 35, 0), "0888230531", 740));
            gsm.AddCall(new Call(new DateTime(2014, 3, 2, 18, 01, 0), "112", 1600));

            //Display the information about the calls
            Console.WriteLine(gsm.GetCallHistory());

            //Print the total price of the calls in the history
            Console.WriteLine("Total price: {0:F2}", gsm.CalculatePrice(PricePerMinute));
            Console.WriteLine();

            //Remove the longest call from the history 
            gsm.CallHistory.RemoveAll(x => x.Duration == gsm.CallHistory.Max(y => y.Duration));

            //Calculate the total price again
            Console.WriteLine("Total price: {0:F2}", gsm.CalculatePrice(PricePerMinute));

            //Clear the call history and print it
            gsm.ClearCallHistory();
            Console.WriteLine();
            Console.WriteLine(gsm.GetCallHistory());
        }       
    }
}
