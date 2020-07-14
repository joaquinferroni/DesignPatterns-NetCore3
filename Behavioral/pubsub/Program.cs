using System;
using System.Threading.Tasks;

namespace pubsub
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher youtube = new Publisher("Youtube.Com");
            Publisher facebook = new Publisher("Facebook.com");

            //Create Instances of Subscribers
            Subscriber sub1 = new Subscriber("Juan ");
            Subscriber sub2 = new Subscriber("Lucas");
            Subscriber sub3 = new Subscriber("Ellen");

            //Pass the publisher obj to their Subscribe function
            sub1.Subscribe(facebook); //sub1 subscribes to facebook publisher
            sub3.Subscribe(facebook);

            sub1.Subscribe(youtube);
            sub2.Subscribe(youtube);

            //sub1.Unsubscribe(facebook);

            youtube.Publish();
            facebook.Publish();

            sub2.Unsubscribe(youtube);

            youtube.Publish();
        }
    }
}
