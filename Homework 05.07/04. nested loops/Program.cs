using System;

namespace _04._nested_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            for(int i = firstNum; i < secondNum; i++)
            {
                string currNum = i.ToString();
                int oddNumsSum = 0;
                int evenNumSum = 0;
                for (int j = 0; j < currNum.Length; j++)
                {
                    int currDigit = int.Parse(currNum[j].ToString());
                    if (j % 2 == 0)
                    {
                        evenNumSum +=currDigit;
                    }
                    else
                    {
                        oddNumsSum += currDigit;
                    }
                    
                  
                }
                if(oddNumsSum == evenNumSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
