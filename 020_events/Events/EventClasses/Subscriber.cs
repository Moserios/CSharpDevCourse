using System;
using EventClasses;

namespace EventClasses
{
    public class Subscriber
    {
        public void Add(int a, int b)
        {
            a++; b++;
            Console.WriteLine($"Subscriber received and processed the event. A++ = {a}, B++ = {b}");
        }
    }
}
