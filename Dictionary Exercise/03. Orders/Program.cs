using System;

namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine()!;
            Dictionary<string, List<double>> orders = new Dictionary<string, List<double>>();
            while (productName != "buy")
            {
                string[] vs = productName.Split(' ');
                string product = vs[0];
                List<double> list = new List<double>();
                list.Add(double.Parse(vs[1]));
                list.Add(double.Parse(vs[2]));
                if (orders.ContainsKey(product))
                {
                    orders[product][1] += double.Parse(vs[2]);
                    orders[product][0] = double.Parse(vs[1]);
                }
                else
                {
                    orders.Add(product, list);
                }
                productName = Console.ReadLine()!;

            }
            foreach (var order in orders)
            {
                Console.WriteLine($"{order.Key} -> {(order.Value[0] * order.Value[1]):f2}");
            }
        }
    }
}