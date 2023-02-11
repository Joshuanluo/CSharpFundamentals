namespace EnumDemo;
public enum ShippingMethod
{
    RegularAirMail=1,
    RegisteredAirmail=2,
    Express=3
}
class Program
{
    static void Main(string[] args)
    {
        var method = ShippingMethod.Express;
        Console.WriteLine((int)method);

        var methodId = 3;
        Console.WriteLine((ShippingMethod)methodId);

        Console.WriteLine(method.ToString());

        var methodName = "Express";
        var shipmethod=(ShippingMethod)Enum.Parse(typeof(ShippingMethod),methodName);
        Console.WriteLine(shipmethod);
    }
}

