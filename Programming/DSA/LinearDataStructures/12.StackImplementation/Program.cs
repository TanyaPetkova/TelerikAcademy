namespace StackImplementation
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Stack<string> stack = new Stack<string>();

            stack.Push("1. Doncho");
            stack.Push("2. Evlogi");
            stack.Push("3. Ivaylo");
            stack.Push("4. Nikolay");
            Console.WriteLine(stack.Capacity);

            //Test auto resizing
            stack.Push("5. Todor");
            Console.WriteLine(stack.Capacity);

            Console.WriteLine("Top = {0}", stack.Peek());
            while (stack.Count > 0)
            {
                string personName = stack.Pop();
                Console.WriteLine(personName);
            }
        }
    }
}
