using System;

namespace Generics
{
    public class Person
    {
        public string FirstName { get; init; } = string.Empty;

        public string LastName { get; init; } = string.Empty;

        public void Print()
        {
            Console.WriteLine($"Hello my name is {FirstName} {LastName}");
        }
    }
}
