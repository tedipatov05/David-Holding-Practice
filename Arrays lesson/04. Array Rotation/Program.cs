using System;

namespace _04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int swaps = int.Parse(Console.ReadLine());

            for (int i = 0; i < swaps ; i++)
            {
                int swapValue = arr[0];
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    arr[j] = arr[j+1];   
                }
                arr[arr.Length - 1] = swapValue;

            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
