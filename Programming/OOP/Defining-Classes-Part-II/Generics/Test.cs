namespace Generics
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Test
    {
        static void Main()
        {
            GenericList<int> list = new GenericList<int>();

            //Add some numbers in the list
            list.Add(1);
            list.Add(2);
            list.Add(6);
            list.Add(8);

            //Insert number at given position in the list
            list.Insert(3, 1);
            Console.WriteLine("List: {0}", list);
            Console.WriteLine("Count: {0}", list.Count);
            Console.WriteLine("Capacity: {0}", list.Capacity);

            //Find a number and get its index in the list
            Console.WriteLine("The number 3 is at position {0} in the list.", list.Find(3));

            //Get min and max numbers in the list
            Console.WriteLine("Max: " + list.Max());
            Console.WriteLine("Min: " + list.Min());

            //Clear the list
            list.Clear();
            Console.WriteLine("List: {0}", list);
        }
    }
}
