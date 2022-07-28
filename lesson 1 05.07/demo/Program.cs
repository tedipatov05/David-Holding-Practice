using System;


namespace _01._if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int amount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double sum = 0.0;
            if (type == "Roses")
            {
                if (amount > 80)
                    sum = amount * 5 - 0.1 * (amount * 5);
                sum = amount * 5;
            }

            if (type == "Dahlias")
            {
                if (amount > 90)
                    sum = amount * 3.80 - 0.15 * (amount * 3.80);
                sum = amount * 3.80;
            }

            if (type == "Tulips")
            {
                if (amount > 80)
                    sum = amount * 2.80 - (0.15 * amount * 2.80);
                sum = amount * 2.80;
            }



            if (type == "Narcissus")
            {
                if (amount < 120)
                    sum = amount * 3 + 0.15 * (amount * 3);
                sum = amount * 3.80;
            }



            if (type == "Gladiolus")
            {
                if (amount < 120)
                    sum = amount * 2.5 + 0.15 * (amount * 2.5);

                sum = amount * 2.5;

            }

            if (budget >= sum)
            {
                Console.WriteLine($"Hey, you have a great garden with {amount} {type} and {budget - sum:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {sum - budget:f2} leva more.");
            }



        }
    }
}

