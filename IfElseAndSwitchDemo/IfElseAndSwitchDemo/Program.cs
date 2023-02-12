namespace IfElseAndSwitchDemo;
class Program
{
    static void Main(string[] args)
    {
        int hour = 10;
        if (hour>0 && hour<12)
            Console.WriteLine("It's morning.");
        else if(hour>=12&&hour<18 )
            Console.WriteLine("it's afternoon.");
        else
            Console.WriteLine("it's evening.");

        var season = Season.Winter;
        switch (season)
        {
            case Season.Autumn:
                Console.WriteLine("it's autumn");
                break;
            case Season.Summer:
                Console.WriteLine("it's summer");
                break;
            case Season.Spring:
            case Season.Winter:
                Console.WriteLine("it's spring or winter");
                break;
            default:
                Console.WriteLine("I don't understand.");
                break;
        }
    }
}

