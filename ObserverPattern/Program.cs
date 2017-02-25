using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher MyTwitter = new Publisher();

            ISubscriber tabletSubscriber = new TabletSubscriber();
            MyTwitter.AddSubscriber(tabletSubscriber);
            MyTwitter.AddSubscriber(new MobileSubscriber());

            MyTwitter.NotifySubscribers("Hello World!!");

            MyTwitter.RemoveSubscriber(tabletSubscriber);
            MyTwitter.NotifySubscribers("Hello New World!!");

            Console.ReadLine();
        }
    }
}
