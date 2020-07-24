using System;

namespace strategy
{
    class Program
    {
        static void Main(string[] args)
        {
             var context = new SortContext();

            Console.WriteLine("Client: Strategy is set to normal sorting.");
            context.SetStrategy(new AscStrategy());
            context.DoSort();
            
            Console.WriteLine();
            
            Console.WriteLine("Client: Strategy is set to reverse sorting.");
            context.SetStrategy(new DescStrategy());
            context.DoSort();
        }
    }
}
