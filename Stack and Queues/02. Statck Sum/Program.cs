using System;

namespace _02._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            string command = Console.ReadLine();

            while(command.ToLower() != "end")
            {
                string[] cmdArgs = command.Split();

                string type = cmdArgs[0].ToLower();
                if(type == "add")
                {
                    int num1 = int.Parse(cmdArgs[1]);
                    int num2 = int.Parse(cmdArgs[2]);

                    stack.Push(num1);
                    stack.Push(num2);
                }
                else if(type == "remove")
                {
                    int count = int.Parse(cmdArgs[1]);

                    if (count > stack.Count)
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                    }
                }


                command = Console.ReadLine();
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}