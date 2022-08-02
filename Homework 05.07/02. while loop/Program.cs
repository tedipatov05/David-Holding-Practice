using System;

namespace _02._while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countBadMarks = int.Parse(Console.ReadLine());
            int countTask = 0;
            double marks = 0;
            int badMarks = 0;
            string lastTask = string.Empty;
            while(true)
            {
                string task = Console.ReadLine();
                if(task == "Enough")
                {
                    
                    Console.WriteLine($"Average score: {marks/countTask:f2}");
                    Console.WriteLine($"Number of problems: {countTask}");
                    Console.WriteLine($"Last problem: {lastTask}");
                    return;
                }
                lastTask = task;
                int mark = int.Parse(Console.ReadLine());
                marks += mark;
                if(mark <= 4)
                {
                    badMarks++;
                }
                if(badMarks == countBadMarks)
                {
                    Console.WriteLine($"You need a break, {badMarks} poor grades.");
                    return;
                }
                countTask++;    

            }

            
        }
    }
}
