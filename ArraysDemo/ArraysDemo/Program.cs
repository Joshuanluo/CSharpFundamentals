namespace ArraysDemo;
class Program
{
    static void Main(string[] args)
    {
        var numbers = new int[] {3,1,5,2,0,9,6,8,7};
        //Length
        Console.WriteLine("Length: " + numbers.Length);

        //indexOf
        var index = Array.IndexOf(numbers, 6);
        Console.WriteLine("index of 9 in numbers is: " + index);

        //clear
        Array.Clear(numbers, 1, 2);
        Console.WriteLine("effect of clear()");
        foreach(var number in numbers)
        {
            Console.WriteLine(number);
        }


        //cpoy
        var another = new int[4];
        Array.Copy(numbers, another, 4);
        Console.WriteLine("effect of copy()");
        foreach (var number in another)
        {
            Console.WriteLine(number);
        }

        //sort
        Array.Sort(numbers);
        Console.WriteLine("effect of sort()");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        //reserve
        Array.Reverse(numbers);
        Console.WriteLine("effect of reserve()");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}

