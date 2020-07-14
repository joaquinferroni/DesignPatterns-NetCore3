using System;

class ConcreteObserver3 : IObserver
    {
        public void Update(ISubject subject)
        {
            Console.WriteLine($"ConcreteObserver3: State has changed to {(subject as ConcreteSubject).State}");
        }
    }