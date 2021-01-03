using System;
using OOP2;

namespace OOP2Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test that a person can be created.
            Person person = new Person("Mads", 30);

            Console.WriteLine("Tjek at det er det korrekte navn og alder der står herunder:");

            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
        }
    }
}
