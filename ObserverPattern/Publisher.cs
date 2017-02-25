using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Publisher
    {
        private List<ISubscriber> subscribers;

        public Publisher()
        {
            subscribers = new List<ISubscriber>();
        }

        public void AddSubscriber(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void RemoveSubscriber(ISubscriber subscriber)
        {
            if (subscribers.Contains(subscriber))
                subscribers.Remove(subscriber);

        }

        public void NotifySubscribers(string tweet)
        {
            foreach (var s in subscribers)
            {
                s.DisplayNotification(tweet);
            }
        }
    }
}
