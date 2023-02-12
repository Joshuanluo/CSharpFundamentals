namespace IterationDemo;
class Program
{
    static void Main(string[] args)
    {
        //For Loop
        var name = "David Jones";
        for (int j = 0; j < name.Length; j++)
        {
            Console.WriteLine(name[j]);
        }
        Console.WriteLine("------------------");

        for (var j = 0; j < 10; j++)
        {
            if (j % 2 == 0)
                Console.WriteLine(j);
        }
        Console.WriteLine("------------------");

        //Foreach
        foreach (var cha in name)
        {
            Console.WriteLine(cha);
        }


        Console.WriteLine("------------------");
        var numbers = new int[] { 1, 2, 3, 4 };
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        //While Loop
        Console.WriteLine("------------------");
        var i = 0;
        while (i <= 10)
        {
            if (i % 2 == 0)
                Console.WriteLine(i);
            i++;
        }

        Console.WriteLine("------------------");

    }
}

