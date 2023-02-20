namespace ListsDemo;
class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int>() { 1, 2, 3, 4 };
        numbers.Add(1);
        numbers.AddRange(new int[]{ 4,5,6,7});
        foreach(var n in numbers)
            Console.WriteLine(n);

        Console.WriteLine();

        //indexOf
        Console.WriteLine("index of 1: "+numbers.IndexOf(1));
        Console.WriteLine("last index of 1: " + numbers.LastIndexOf(1));

        //count
        Console.WriteLine("Count of list: "+numbers.Count());

        //remove
        numbers.Remove(1);
        Console.WriteLine("remove 1");
        foreach (var n in numbers)
            Console.WriteLine(n);

        //remove all 1 in the list
        for (var i = 0; i < numbers.Count();i++)
        {
            if (numbers[i] ==1)
            {
                numbers.Remove(numbers[i]);
            }
        }
        Console.WriteLine("remove all 1 in the list");
        foreach (var n in numbers)
            Console.WriteLine(n);
    }
}

