




List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

int count = list.Count;

for(int i = 0; i<count/2; i++)
{
    list[i] += list[list.Count - 1];
    list.RemoveAt(list.Count - 1);
}

Console.WriteLine(String.Join(" ", list));