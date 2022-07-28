

using System.Linq;

List<int> list = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .Where(x => x > 0)
    .Reverse()
    .ToList();


Console.WriteLine(String.Join(" ", list));



