namespace _11.LinkedListImplementation
{
    using System;
    
    public class Program
    {
        public static void Main()
        {
            LinkedList<string> list = new LinkedList<string>();
            ListItem<string> node = new ListItem<string>("Pesho");

            list.FirstElement = node;
            list.AddLast("Gosho");
            list.AddLast("Ivan");

            Console.WriteLine(list);

            ListItem<string> newNode = new ListItem<string>("Ivo");
            list.AddAfter(node, newNode);
            Console.WriteLine(list);
            list.AddAfter(newNode, "Doncho");
            Console.WriteLine(list);

            Console.WriteLine("Test AddBefore(): ");
            list.AddBefore(node, newNode);
            Console.WriteLine(list);

            Console.WriteLine("Test RemoveFirst(): ");
            list.RemoveFirst();
            Console.WriteLine(list);

            Console.WriteLine("Test RemoveLast(): ");
            list.RemoveLast();
            Console.WriteLine(list);
        }
    }
}
