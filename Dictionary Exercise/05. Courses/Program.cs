using System;

namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine()!;
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            while (input != "end")
            {
                string[] vs = input.Split(" : ");
                if (!courses.ContainsKey(vs[0]))
                {
                    courses.Add(vs[0], new List<string> { vs[1] });

                }
                else
                {
                    courses[vs[0]].Add(vs[1]);
                }
                input = Console.ReadLine()!;
            }
            foreach(var kvp in courses)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count()}");
                foreach (string v in kvp.Value)
                {
                    Console.WriteLine($"-- {v}");
                }
            }
        }
    }
}
