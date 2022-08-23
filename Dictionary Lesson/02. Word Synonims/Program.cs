using System;

namespace _02._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pairCount = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
           
            for (int i = 0; i < pairCount; i++)
            {
                string? word = Console.ReadLine();
                string? synonym = Console.ReadLine();
                if (dictionary.ContainsKey(word))
                {
                    dictionary[word].Add(synonym);
                }
                else
                {
                    List<string> list = new List<string>() { synonym };
                    dictionary.Add(word, list);
                }
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}