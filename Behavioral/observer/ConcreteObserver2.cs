using System;

class ConcreteObserver2 : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as ConcreteSubject).State == 0 || (subject as ConcreteSubject).State >= 2)
            {
                Console.WriteLine("ConcreteObserver2: Reacted to the event.");
            }
        }
    }