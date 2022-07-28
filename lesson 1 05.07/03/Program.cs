using System;

namespace _03_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentNum = 1;

            int num = 1;
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(num + " ");
                    num++;
                    if (num > n)
                    {
                        Console.WriteLine();
                        return;
                    }
                }
                Console.WriteLine();

            }
            
        }
    }
}
