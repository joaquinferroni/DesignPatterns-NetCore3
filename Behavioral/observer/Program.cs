using System;

namespace observer
{
    class Program
    {
        static void Main(string[] args)
        {
           var subject = new ConcreteSubject();
            var observer1 = new ConcreteObserver1();
            subject.Attach(observer1);

            var observer2 = new ConcreteObserver2();
            subject.Attach(observer2);

            var observer3 = new ConcreteObserver3();
            subject.Attach(observer3);

        
            subject.BusinessLogic();
            subject.BusinessLogic();

            subject.Detach(observer3);

            subject.BusinessLogic();
        }
    }
}
