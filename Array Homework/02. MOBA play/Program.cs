using System;

namespace _02._MOBA_play
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            int priceHeadset = int.Parse(Console.ReadLine());
            int priceMouse = int.Parse(Console.ReadLine());
            int priceKeyboard = int.Parse(Console.ReadLine());
            int priceDisplay = int.Parse(Console.ReadLine());
            int totalExpence = 0;
            for(int i = 1; i <= lostGamesCount; i++)
            {
                if (i % 2 == 0)
                {
                    totalExpence += priceHeadset;
                }
                if(i % 3 == 0)
                {
                    totalExpence += priceMouse;
                }
                if(i %3 == 0 && i % 2 == 0)
                {
                    totalExpence += priceKeyboard;
                }
            }
            Console.WriteLine($"Rage expences: {totalExpence:f2} lv.");


        }
    }
}