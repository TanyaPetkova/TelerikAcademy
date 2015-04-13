namespace ArticlesRetriever
{
    using System;
    using System.Diagnostics;
    using Wintellect.PowerCollections;

    public class Program
    {
        public static void Main()
        {
            OrderedMultiDictionary<int, Article> dict = new OrderedMultiDictionary<int, Article>(true);
            Console.WriteLine("Filling data in the dictionary...");

            var sw = new Stopwatch();
            sw.Start();

            for (int i = 0; i < 1000000; i++)
            {
                dict.Add(i % 50, new Article("barcode", "vendor", "title", i % 50));
            }

            Console.WriteLine(sw.Elapsed);

            sw.Restart();

            Console.WriteLine("Retrieving articles in given range:");
            for (int i = 0; i < 1000000; i++)
            {
                dict.Range(i % 100, true, i % 100, true);
            }

            Console.WriteLine(sw.Elapsed);
        }
    }
}
