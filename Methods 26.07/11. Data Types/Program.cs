using System;

namespace _11._Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if(type == "int")
            {
                int value = int.Parse(Console.ReadLine());
                ManipulateDataTypes(value);
            }
            else if(type == "real")
            {
                double value = double.Parse(Console.ReadLine());
                ManipulateDataTypes(value);

            }
            else if(type == "string")
            {
                string value = Console.ReadLine();
                ManipulateDataTypes(value);
            }
            


        }
        public static void ManipulateDataTypes(int value)
        {
                
                Console.WriteLine(value*2);
        }
        public static void ManipulateDataTypes(double value)
        {
            
            Console.WriteLine($"{value * 1.5:f2}");
        }
        public static void ManipulateDataTypes(string value)
        {
          
            Console.WriteLine($"${value}$");
        }

    }
}
