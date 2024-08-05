using System;
using EventClasses;

namespace Events
{
    internal class Program
    {
        static void Main()
        {
            // Custom Event
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();
            publisher.myEvent += subscriber.Add;
            publisher.RaiseEvent(10, 20);


            // Auto-implemented Events
            AutoPublisher autoPublisher = new AutoPublisher();
            Subscriber subscriber1 = new Subscriber();
            autoPublisher.myEvent += subscriber1.Add;       
            autoPublisher.RaiseEvent(100, 200);

            Console.ReadKey();
        } 
    }
}
