using System;
using System.Collections.Generic;


namespace _01._Countr_Real_Numbers
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Dictionary<double, int> countNumbers = new Dictionary<double, int>();

            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            foreach(double number in numbers)
            {
                if (countNumbers.ContainsKey(number))
                {
                    countNumbers[number]++;
                }
                else
                {
                    countNumbers.Add(number, 1);
                }
            }

            foreach(KeyValuePair<double, int> n in countNumbers.OrderBy(n => n.Key))
            {
                Console.WriteLine($"{n.Key} -> {n.Value}");
            }
            
           


        }
    }
}