namespace WordOccurancesCounter
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /* Write a program that counts how many times each word from given text file words.txt appears in it. 
       The character casing differences should be ignored. 
       The result words should be ordered by their number of occurrences in the text. Example
       This is the TEXT. Text, text, text – THIS TEXT! Is this the text?
       is -> 2
	   the -> 2
	   this -> 3
	   text -> 6 */
    /// </summary>
    public class Program
    {
        public static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\words.txt");
            IDictionary<string, int> occurances = new SortedDictionary<string, int>();
            occurances = CountOccucarncesInFile(reader, occurances);
            PrintDictionary(occurances);
        }

        public static IDictionary<string, int> CountOccucarncesInFile(StreamReader reader, IDictionary<string, int> occurancesCount)
        {
            string line = string.Empty;
            char[] separators = new char[] { ' ', ',', '.', '!', '?', '-' };
            line = reader.ReadLine();

            while (line != null)
            {
                string[] currentLine = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < currentLine.Length; i++)
                {
                    currentLine[i] = currentLine[i].ToLower();
                    int count;
                    if (!occurancesCount.TryGetValue(currentLine[i], out count))
                    {
                        count = 0;
                    }

                    occurancesCount[currentLine[i]] = ++count;
                }

                line = reader.ReadLine();
            }

            return occurancesCount;
        }

        public static void PrintDictionary(IDictionary<string, int> dict)
        {
            foreach (var element in dict)
            {
                Console.WriteLine("{0} -> {1} times", element.Key, element.Value);
            }
        }
    }
}
