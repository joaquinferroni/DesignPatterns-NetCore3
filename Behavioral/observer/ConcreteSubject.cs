
using System;
using System.Collections.Generic;
using System.Threading;

public class ConcreteSubject : ISubject
    {
        // For the sake of simplicity, the Subject's state, essential to all
        // subscribers, is stored in this variable.
        public int State { get; set; } = -0;
        private List<IObserver> _observers = new List<IObserver>();
        public void Attach(IObserver observer) =>this._observers.Add(observer);
        public void Detach(IObserver observer) => this._observers.Remove(observer);

        // Trigger an update in each subscriber.
        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

       
        public void BusinessLogic()
        {
            this.State = new Random().Next(0, 10);
            Console.WriteLine($"State has new Value to: {this.State}");
            Thread.Sleep(1500);
            Console.WriteLine("Notifying...");
            this.Notify();
        }
    }