namespace Classes
{
    public class Producer
    {
        public delegate void MyDelegateType(int a, int b);

        class Publisher
        {
            //private delegate
            private MyDelegateType m; 
            //create event + - subscription
            public event MyDelegateType myEvent
            {
                add { m += value; }
                remove { m -= value; }
            }

            //raise the event
            public void RaiseEvent(int a, int b)
            {
                if (m != null)
                {
                    this.m(a, b);
                }
            }
        }

    }
}
