using System;

namespace stringFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you first name: ");
            string firstName = Console.ReadLine();
            var upperFirstName = firstName.ToUpper();

            Console.WriteLine("Enter you last name: ");
            string lastName = Console.ReadLine();
            var upperLastName = lastName.ToUpper();

            Console.WriteLine($"Your initials are: '{upperFirstName[0]}.{upperLastName[0]}'");
        }
    }
}
