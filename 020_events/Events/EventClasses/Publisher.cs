using System;

namespace EventClasses
{
    public delegate void MyDeleg(int a, int b);

    public class Publisher
    {
        //private delegate
        private MyDeleg m;

        //create event + - subscription
        public event MyDeleg myEvent
        {
            add { m += value; }
            remove { m -= value; }
        }

        //raise the event
        public void RaiseEvent(int a, int b)
        {
            if (m != null)
            {
                Console.WriteLine($"\nPublisher creates event: {a} {b}.");
                this.m(a, b);
            }
        }
    }

    public class AutoPublisher
    {
        //create event + - subscription
        public event MyDeleg myEvent;
      
        //raise the event
        public void RaiseEvent(int a, int b)
        {
            if (myEvent != null)
            {
                Console.WriteLine($"\nAutoPublisher creates event: {a} {b}.");
                this.myEvent(a, b);
            }
        }
    }

}
