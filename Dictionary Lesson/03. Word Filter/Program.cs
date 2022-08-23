using System;
using System.Linq;

namespace _03._Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split()
                .Where(s => s.Length % 2 == 0)
                .ToList();

            Console.WriteLine(String.Join(Environment.NewLine, list));
               
        }
    }
}
