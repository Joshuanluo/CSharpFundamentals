using System;
namespace StringDemo{
    class StringDemo
    {
        public static void Main(string[] args)
        {
            var firstName = "Mosh";
            var lastName = "L";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            var text = "Hi Josh\nLook into the following paths\nc:\\floder1\\floder2\nc:\\floder3\\floder4";
            var text1 = @"Hi Josh
Look into the following paths
c:\floder1\floder2
c:\floder3\floder4";
            Console.WriteLine(text);
            Console.WriteLine(text1);
        }
    }
}