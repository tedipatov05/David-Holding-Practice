using System;
using System.Linq;

namespace LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short sizeOfField = short.Parse(Console.ReadLine());    // Field size input

            if(sizeOfField > 1000)
            {
                throw new ArgumentOutOfRangeException(nameof(sizeOfField));
            }

            int[] initIndexes = Console.ReadLine()  // Array of the ladybug indexes of the next array
                                .Split(" ")
                                .Select(int.Parse)
                                .ToArray();

            int[] ladybugArray = new int[sizeOfField];  // Creating the lady bug array

            for (int i = 0; i < initIndexes.Length; i++)    // Filling the ladybug array with 1s on their indexes
            {
                if (initIndexes.Contains(i))
                {
                    ladybugArray[i] = 1;
                }
                else
                {
                    ladybugArray[i] = 0;
                }
                

              
            }

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandArray = command.Split();

                int ladybugPossition = int.Parse(commandArray[0]);
                string direction = commandArray[1];
                int flyLength = int.Parse(commandArray[2]);

                if(ladybugPossition < 0 || ladybugPossition > sizeOfField -1 )
                {
                    command = Console.ReadLine();
                    continue;
                }
                if (ladybugArray[ladybugPossition] == 0)
                {
                    command = Console.ReadLine();
                    continue;
                }

                ladybugArray[ladybugPossition] = 0;

                switch (direction)
                {
                    case "right":
                        {
                            if (ladybugPossition + flyLength > sizeOfField - 1) 
                            {
                                break;
                            } 
                            for (int i = ladybugPossition + flyLength; i < ladybugArray.Length; i+=flyLength)
                            {
                                if (ladybugArray[i] == 0)
                                {
                                    ladybugArray[i] = 1;
                                    break;
                                }
                                
                            }
                            break;
                        }
                    case "left":
                        {
                            if (ladybugPossition - flyLength < 0)
                            {
                                break;
                            }
                            for (int i = ladybugPossition - flyLength; i >= 0; i -= flyLength)
                            {
                                if (ladybugArray[i] == 0)
                                {
                                    ladybugArray[i] = 1;
                                    break;
                                }

                            }
                            break;
                        }
                    default: throw new ArgumentException("Wrong direction");
                }

                command = Console.ReadLine();

            }


            Console.WriteLine(string.Join(" ", ladybugArray));
        }
    }
}
