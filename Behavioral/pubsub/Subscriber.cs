using System;

class Subscriber{

    public string SubscriberName { get; private set; }

    public Subscriber(string _subscriberName)
    {
        SubscriberName = _subscriberName;
    }

    public void Subscribe(Publisher p)
    {
        p.Notify += OnNotificationReceived; 
    }
    public void Unsubscribe(Publisher p)
    {
        p.Notify -= OnNotificationReceived;  
    }
    protected virtual void OnNotificationReceived(Publisher p, NotificationEvent e)
    {

        Console.WriteLine("Hey " + SubscriberName + ", " + e.NotificationMessage +" - "+ p.PublisherName + " at " + e.NotificationDate);
    }
}