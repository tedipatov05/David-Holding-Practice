using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    public class Program
    {
        static void Main(string[] args)
        {
            string chars = Console.ReadLine()!;
            Dictionary<char, int> occurrences = new Dictionary<char, int>();
            for (int i = 0; i < chars.Length; i++)
            {
                char[] arr = chars.ToCharArray();
                if (occurrences.ContainsKey(arr[i]))
                {
                    occurrences[arr[i]]++;
                }
                else if (arr[i] != ' ')
                {
                    occurrences.Add(arr[i], 1);
                }

            }
            foreach (var occurrence in occurrences)
            {
                Console.WriteLine($"{occurrence.Key} -> {occurrence.Value}");
            }
        }
    }
}