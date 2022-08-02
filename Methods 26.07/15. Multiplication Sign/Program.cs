using System;
using System.Linq;

namespace _15._Multiplication_Sign 
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());

            ReturnSign(numberOne, numberTwo, numberThree);
        }

        private static void ReturnSign(int numberOne, int numberTwo, int numberThree)
        {
            int[] numbers = { numberOne, numberTwo, numberThree };
            int countOfNegative = 0;
            int countOfPositive = 0;


            foreach (int number in numbers)
            {
                if (number < 0)
                {
                    countOfNegative++;
                }
                else if (number > 0)
                {
                    countOfPositive++;
                }
            }


            if (numberOne == 0 || numberTwo == 0 || numberThree == 0)
            {
                Console.WriteLine("zero");
            }
            else if (countOfPositive == 3)
            {
                Console.WriteLine("positive");
            }
            else if (countOfPositive == 1 && countOfNegative == 2)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
        }
    }
}
