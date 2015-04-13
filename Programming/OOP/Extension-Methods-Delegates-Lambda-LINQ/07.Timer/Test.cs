namespace _07.Timer
{
    using System;

    class Test
    {
        static void TestMethod()
        {
            Console.WriteLine("This method was executed at {0}.", DateTime.Now);
        }

        static void Main()
        {
            Timer timer = new Timer(2, TestMethod);
        }
    }
}
