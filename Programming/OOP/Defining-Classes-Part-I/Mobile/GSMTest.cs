namespace Mobile
{
    using System;

    class GSMTest
    {
        public static void Test()
        {
            //Create an array of few instances of the GSM class
            GSM[] gsms = new GSM[3];

            string[] models = { "NokiaN95", "HTCDesire", "Iphone5S" };
            string[] manufacturer = { "Nokia", "HTC", "Apple" };
            double?[] price = { 400, 300, 1500 };
            string[] owner = { "Pesho", "Gosho", "Tosho" };

            Battery nokia95Battery = new Battery("BL-5F", 220, 6.5, BatteryType.LiIon);
            Battery htcDesireBattery = new Battery("E205823", 340, 6.4, BatteryType.LiIon);
            Battery iPhone5SBattery = new Battery("616-0613", 250, 10, BatteryType.LiIon);

            Battery[] batteries = { nokia95Battery, htcDesireBattery, iPhone5SBattery};

            Display nokia95Display = new Display(2.6, 16000000);
            Display htcDesireDisplay = new Display(3.7, 16000000);
            Display iPhone5SDisplay = new Display(4, 16000000);

            Display[] displays = { nokia95Display, htcDesireDisplay, iPhone5SDisplay };

            //Display the information about the GSMs in the array
            for (int i = 0; i < gsms.Length; i++)
            {
                gsms[i] = new GSM(models[i], manufacturer[i], price[i], owner[i], batteries[i], displays[i]);
                Console.WriteLine(gsms[i].ToString());
                Console.WriteLine();
            }

            //Display the information about the static property IPhone4S
            Console.WriteLine(GSM.IPhone4S);

        }
    }
}
