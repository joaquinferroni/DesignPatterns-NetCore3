using System;
using System.Threading;

namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            InstantiateSingleton("FOO");

             Thread process1 = new Thread(() =>
            {
                TestSingleton("1");
            });
            Thread process2 = new Thread(() =>
            {
                ChangeSingletonValue("VAR");
                TestSingleton("2");
            });

             Thread process3 = new Thread(() =>
            {
                TestSingleton("3");
            });
            Thread process4 = new Thread(() =>
            {
                TestSingleton("4");
            });
            
            process1.Start();
            process2.Start();
            process3.Start();
            process4.Start();
            
            process1.Join();
            process2.Join();
            process3.Join();
            process4.Join();
            Console.WriteLine("Hello World!");
        }


        public static void InstantiateSingleton(string value){
            Singleton singleton = Singleton.GetInstance(value);
            Console.WriteLine($"Instantiate singleton with value: {value}");
        }
        public static void TestSingleton(string thread)
        {
            Singleton singleton = Singleton.GetInstance();
            Console.WriteLine($"thread :{thread} - singleton value: {singleton.Value}");
        } 

        public static void ChangeSingletonValue(string newValue){
            var singleton = Singleton.GetInstance();
            singleton.Value = newValue;
            Console.WriteLine($"Value changed to {newValue}");
        }
    }

}
