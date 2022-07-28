using System;

namespace _02_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            string libraryBook = Console.ReadLine();
            int count = 0;
            while(libraryBook != book && libraryBook!= "No More Books")
            {
                libraryBook = Console.ReadLine();
                count++;
            }
            if(libraryBook == book)
            {
                Console.WriteLine($"You checked {count} books and found it.");
            }
            if(libraryBook == "No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }
        }
    }
}
