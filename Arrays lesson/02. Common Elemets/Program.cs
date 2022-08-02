using System;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split(' ');
            string[] secondArr = Console.ReadLine().Split(' ');
            //int length = firstArr.Length<secondArr.Length ? firstArr.Length : secondArr.Length;           
            for (int i = 0; i < firstArr.Length; i++)
            {
                for(int j = 0; j < secondArr.Length; j++)
                {
                    if(secondArr[j] == firstArr[i])
                    {
                        Console.WriteLine();
                        Console.Write(firstArr[i] + " ");
                    }
                }
            }
        }
    }
}