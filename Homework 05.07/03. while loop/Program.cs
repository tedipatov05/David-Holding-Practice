using System;

namespace _03._while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int goalSteps = 10000;
            int stepsAll = 0;
            while (true)
            {
                string step = Console.ReadLine();
                if(step == "Going home")
                {
                    int stepToHome = int.Parse(Console.ReadLine());
                    stepsAll+=stepToHome;
                    if (stepsAll >= goalSteps)
                    {

                        Console.WriteLine("Goal reached! Good job!");
                        Console.WriteLine($"{stepsAll - goalSteps} steps over the goal!");

                    }
                    else
                    {
                        Console.WriteLine($"{ goalSteps - stepsAll} more steps to reach goal.");
                    }
                    return;
                }
                stepsAll+= int.Parse(step);
                if(stepsAll >= goalSteps)
                {
                    
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{stepsAll-goalSteps} steps over the goal!");
                    return;
                }
            }
        }
    }
}
