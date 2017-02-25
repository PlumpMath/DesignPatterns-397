using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    interface ISubscriber
    {
        void DisplayNotification(string tweet);
    }
    class TabletSubscriber : ISubscriber
    {
        public TabletSubscriber()
        {

        }

        public void DisplayNotification(string tweet)
        {
            Console.WriteLine("Tweet on Tablet : " + tweet);
        }
    }
    class MobileSubscriber : ISubscriber
    {
        public MobileSubscriber()
        {

        }

        public void DisplayNotification(string tweet)
        {
            Console.WriteLine("Tweet on Mobile : " + tweet);
        }
    }
}
