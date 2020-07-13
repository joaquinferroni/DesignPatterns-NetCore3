using System;

namespace builder
{
    class Program
    {
        static void Main(string[] args)
        {
            HouseDirector hd = new HouseDirector();
            ConcreteBigHouse cbh = new ConcreteBigHouse();
            hd.Builder = cbh;

            Console.WriteLine("Empty Big House");
            Console.WriteLine(cbh.ToString());
            
            hd.BuildFullFeaturedHouse();
            Console.WriteLine("Full Big House");
            Console.WriteLine(cbh.ToString());


            ConcreteSmallHouse csh = new ConcreteSmallHouse();
            hd.Builder = csh;
            hd.BuildMinimalHouse();
            
            Console.WriteLine("Poor Small House");
            Console.WriteLine(csh.ToString());
            
            csh.Reset();
            
            hd.BuildFullFeaturedHouse();
            Console.WriteLine("Full Small House");
            Console.WriteLine(csh.ToString());

        }
    }
}
