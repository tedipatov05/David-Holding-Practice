using System;

namespace Grades // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static void PrintGradesInWords(double grade)
        {
            
            if(grade > 2 && grade < 3)
            {
                Console.WriteLine("Fail");
            }
            else if(grade > 3 && grade < 4)
            {
                Console.WriteLine("Poor");
            }
            else if(grade > 4 && grade < 4.50)
            {
                Console.WriteLine("Good");
            }
            else if(grade >= 4.50 && grade < 5.50)
            {
                Console.WriteLine("Very good");
            }
            else if(grade >= 5.50 && grade <= 6)
            {
                Console.WriteLine("Excelent");
            }
        } 
    }
}
