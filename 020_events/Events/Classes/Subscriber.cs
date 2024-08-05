using System;
using Classes;

namespace Classes
{
    public class Subscriber
    {
        public void Add(int a, int b)
        {
            a++; b++;
            Console.WriteLine($"Publisher received the event. A++ = {a}, B++ = {b}");
        }

    }
}
