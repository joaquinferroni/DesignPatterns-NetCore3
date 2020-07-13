using System;

namespace prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Id = 42;
            p1.LastName = "Daniels";
            p1.Name = "Jack ";
            p1.Address = new Address(1,"wall", 956);

            // Perform a shallow copy of p1 and assign it to p2.
            Person p2 =(Person) p1.Clone();

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());

            p1.Address.Number = 123;
            p1.Id = 123;

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
            // Make a deep copy of p1 and assign it to p3.
        }
    }
}
