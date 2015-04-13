namespace HashSetImplementation
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Implement the data structure "set" in a class HashedSet<T> using your class HashTable<K,T> to hold the elements. 
    /// Implement all standard set operations like Add(T), Find(T), Remove(T), Count, Clear(), union and intersect.
    /// </summary>
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("HashSet<T>");
            Console.WriteLine("----------");
            HashSet<string> firstSet = new HashSet<string>() { "Perl", "Java", "C#", "SQL", "PHP" };
            HashSet<string> secondSet = new HashSet<string>() { "Oracle", "SQL", "MySQL" };
            DisplayUnionIntersect(firstSet, secondSet);
        }

        private static void DisplayUnionIntersect(HashSet<string> firstSet, HashSet<string> secondSet)
        {
            Console.Write("First set: ");
            PrintSet(firstSet);

            Console.Write("Second set: ");
            PrintSet(secondSet);

            HashSet<string> union = new HashSet<string>(firstSet);
            union.UnionWith(secondSet);
            Console.Write("Union: ");
            PrintSet(union);

            HashSet<string> intersect = new HashSet<string>(firstSet);
            intersect.IntersectWith(secondSet);
            Console.Write("Intersect: ");
            PrintSet(intersect);
        }

        private static void PrintSet<T>(HashSet<T> set)
        {
            foreach (var element in set)
            {
                Console.Write("{0} ", element);
            }
            Console.WriteLine();
        }
    }
}
