namespace QueueImplementation
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("1. Doncho");
            queue.Enqueue("2. Evlogi");
            queue.Enqueue("3. Ivaylo");
            queue.Enqueue("4. Nikolay");

            Console.WriteLine("Top = {0}", queue.Peek());
            while (queue.Count > 0)
            {
                string personName = queue.Dequeue();
                Console.WriteLine(personName);
            }
        }
    }
}
