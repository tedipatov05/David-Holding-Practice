using System;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
           if(int.TryParse(Console.ReadLine(), out int result))
           {

                PrintSignOfNumber(result);

           }

        }
        static void PrintSignOfNumber(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"The number {num} in positive.");
            }
            else if(num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {num} is zero.");
            }

            



        }
    }
}