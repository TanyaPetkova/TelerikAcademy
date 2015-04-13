namespace HashTableImplementation
{
    using System;

    /// <summary>
    /*Implement the data structure "hash table" in a class HashTable<K,T>. 
      Keep the data in array of lists of key-value pairs (LinkedList<KeyValuePair<K,T>>[]) with initial capacity of 16. 
      When the hash table load runs over 75%, perform resizing to 2 times larger capacity. 
      Implement the following methods and properties: Add(key, value), Find(key)value, Remove( key), 
      Count, Clear(), this[], Keys. Try to make the hash table to support iterating over its elements with foreach.*/
    /// </summary>
    public class Program
    {
        public static void Main()
        {
            HashTable<string, int> studentsMarks = new HashTable<string, int>();
            studentsMarks.Add("Ivan", 4);
            studentsMarks.Add("Peter", 6);
            studentsMarks.Add("Maria", 6);
            studentsMarks.Add("George", 5);

            int peterMark = studentsMarks["Peter"];
            Console.WriteLine("Peter's mark: {0}", peterMark);

            studentsMarks.Remove("Peter");
            Console.WriteLine("Peter removed.");

            Console.WriteLine("Maria's mark: {0}",
                studentsMarks.Find("Maria"));

            Console.WriteLine("Ivan's mark: {0}", studentsMarks["Ivan"]);

            studentsMarks["Ivan"] = 3;
            Console.WriteLine("Ivan's mark changed.");

            // Print all elements of the hash table
            Console.WriteLine("Students and grades:");
            foreach (var studentMark in studentsMarks)
            {
                Console.WriteLine("{0} --> {1}",
                    studentMark.Key, studentMark.Value);
            }
        }
    }
}
