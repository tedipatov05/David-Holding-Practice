﻿using System;

namespace _05._nested_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= 9; i++)
            {

                for (int j = 1; j <= 9; j++)
                {

                    for (int m = 1; m <= 9; m++)
                    {

                        for (int k = 1; k <= 9; k++)
                        {

                            if (n % i == 0 && n % j == 0 && n % m == 0 && n % k == 0)
                            {

                                Console.Write($"{i}{j}{m}{k} ");

                            }

                        }

                    }

                }

            }
        }
    }
}
