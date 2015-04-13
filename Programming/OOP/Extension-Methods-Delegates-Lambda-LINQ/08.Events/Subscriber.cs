namespace _08.Events
{
    using System;

    public class Subscriber
    {
        public Subscriber(Publisher publisher)
        {
            publisher.RaiseEvent += this.TestMethod;
        }

        void TestMethod(object sender, EventArgs e)
        {
            Console.WriteLine("This method was executed at {0}.", DateTime.Now);
        }
    }
}
