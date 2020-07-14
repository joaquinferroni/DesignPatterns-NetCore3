using System;

class ConcreteObserver1 : IObserver
    {
        public void Update(ISubject subject)
        {            
            if ((subject as ConcreteSubject).State < 3)
            {
                Console.WriteLine("ConcreteObserver1: Reacted to the event.");
            }
        }
}