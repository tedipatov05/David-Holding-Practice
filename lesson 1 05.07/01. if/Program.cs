using System;


namespace _01._if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int amount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double sum = 0;
            if(flowers == "Roses")
            {
                if (amount > 80)
                {
                    sum = amount * 5 - 0.10 * amount * 5;
                }
                else
                {
                    sum = amount * 5;
                }
            }
            else if(flowers == "Dahlias")
            {
                if(amount > 90)
                {
                    sum = amount*3.80 - 0.15*amount * 3.80;
                }
                else
                {
                    sum = amount * 3.80;
                }
            } 
            else if(flowers == "Tulips")
            {
                if(amount > 80)
                {
                    sum = (amount * 2.80) - 0.15 * amount * 2.80;
                }
                else
                {
                    sum = amount * 2.80;
                }
            }
            else if(flowers == "Narcissus")
            {
                if(amount < 120)
                {
                    sum = amount * 3 + 0.15 * amount * 3;
                }
                else
                {
                    sum = amount * 3;
                }
            }
           else if(flowers == "Gladiolus")
            {
                if (amount < 80)
                {
                    sum = amount * 2.5 + 0.15 * amount * 2.5;
                }
                else
                {
                    sum = amount * 2.5;
                }
            }
            if(sum <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {amount} {flowers} and {budget-sum:f2} leva left.");

            }
            else
            {
                Console.WriteLine($"Not enough money, you need {sum-budget:f2} leva more.");

            }




        }
    }
}
