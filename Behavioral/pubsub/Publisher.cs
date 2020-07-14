using System;
using System.Threading;

class Publisher
{

    public string PublisherName { get; private set; }
    public Action<Publisher, NotificationEvent> Notify;
    public Publisher(string _publisherName)
    {
        PublisherName = _publisherName;
    }
    public void Publish()
    {
        if (Notify != null)
        {
            NotificationEvent notificationObj = new NotificationEvent(DateTime.Now, "New Notification Arrived from");
            Notify(this, notificationObj);
        }
    }
}