namespace BiDictionaryImplementation
{
    using System;
    /// <summary>
    /// Implement a class BiDictionary<K1,K2,T> that allows adding triples {key1, key2, value} 
    /// and fast search by key1, key2 or by both key1 and key2. 
    /// Note: multiple values can be stored for given key.
    /// </summary>
    public class Program
    {
        public static void Main()
        {
            BiDictionary<string, string, int> persons = new BiDictionary<string, string, int>();

            persons.Add("Nikolay", "Petrov", 21);
            persons.Add("Doncho", "Minkov", 25);
            persons.Add("Ivaylo", "Kenov", 25);
            persons.Add("Nikolay", "Kostov", 23);

            int[] ages = persons.FindByFirstKey("Nikolay");
            Console.WriteLine(string.Join(", ", ages));

            ages = persons.FindBySecondKey("Kenov");
            Console.WriteLine(string.Join(", ", ages));

            ages = persons.FindByBothKeys("Nikolay", "Petrov");
            Console.WriteLine(string.Join(", ", ages));
        }
    }
}
