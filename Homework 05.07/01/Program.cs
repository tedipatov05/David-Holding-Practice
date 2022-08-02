using System;

namespace _01_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int countFishers = int.Parse(Console.ReadLine());
            double rent = 0;
            if (season == "Spring")
            {
                rent = 3000;

                if (countFishers <= 6)
                {
                    rent = rent- rent * 0.1;
                }
                if (countFishers >= 7 && countFishers <= 11)
                {
                    rent = rent - rent * 0.15;
                }
                if (countFishers > 12)
                {
                    rent = rent - rent * 0.25;
                }
               
                if (countFishers % 2 == 0)
                {
                    rent = rent - rent * 0.05;

                }



            }
            else if (season == "Summer")
            {
                rent = 4200;
                if (countFishers <= 6)
                {
                    rent = rent - rent * 0.1;
                }
                if (countFishers >= 7 && countFishers <= 11)
                {
                    rent = rent - rent * 0.15;
                }
                if (countFishers > 12)
                {
                    rent = rent - rent * 0.25;
                }

                if (countFishers % 2 == 0)
                {
                    rent = rent - rent * 0.05;

                }
            }
            else if (season == "Autumn")
            {
                rent = 4200;
                if (countFishers <= 6)
                {
                    rent = rent - rent * 0.1;
                }
                if (countFishers >= 7 && countFishers <= 11)
                {
                    rent = rent - rent * 0.15;
                }
                if (countFishers > 12)
                {
                    rent = rent - rent * 0.25;
                }

               

            }
            else if (season == "Winter")
            {
                rent = 2600;
                if (countFishers <= 6)
                {
                    rent = rent - rent * 0.1;
                }
                if (countFishers >= 7 && countFishers <= 11)
                {
                    rent = rent - rent * 0.15;
                }
                if (countFishers > 12)
                {
                    rent = rent - rent * 0.25;
                }

                if (countFishers % 2 == 0)
                {
                    rent = rent - rent * 0.05;

                }

            }
            if (budget >= rent)
            {
                Console.WriteLine($"Yes! You have {budget-rent:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {rent-budget:f2} leva.");
            }


        }
    }
}
