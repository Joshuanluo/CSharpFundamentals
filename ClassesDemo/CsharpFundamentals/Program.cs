using ClassesDemo.Math;
using CsharpFundamentals;

namespace ClassesDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Person josh = new Person();
            josh.FirstName = "Josh";
            josh.LastName = "L";
            josh.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
} 