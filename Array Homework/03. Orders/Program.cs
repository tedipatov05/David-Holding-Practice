using System;

namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] prices = new double[n];
            for (int i = 0; i < n; i++)
            {
                double pricePerCaps = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());
                double sum = (days * capsulesCount) * pricePerCaps;
                prices[i] = sum;
            }
            foreach(int price in prices)
            {
                Console.WriteLine($"The price for the coffee is: {price:f2}");
            }
            Console.WriteLine($"Total:{ prices.Sum():f2}");
           
        }
    }
}