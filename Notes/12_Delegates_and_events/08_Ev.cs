using System;
// Demonstrates how to use a multicast event.
namespace Event_3
{
    // Declare an event delegate
    delegate void MyEventHandler();
    // Declare an event class
    class MyEvent
    {
        public event MyEventHandler SomeEvent;
        // This method is called to generate an event.
        public void OnSomeEvent()
        {
            // If 'a' calculated as null, then the result of 'a?.X' is null.
            // If 'a' calculated as a non-null value, the result of 'a?.X' is the same as the result of 'a.X'.
            // Invoke() - invokes the method represented by the current instance of SomeEvent?.Invoke();
        }
    }
    class X
    {
        public void Xhandler()
        {
            Console.WriteLine("Event received by object X.");
        }
    }
    class Y
    {
        public void Yhandler()
        {
            Console.WriteLine("Event received by object Y.");
        }
    }
    class Program
    {
        static void Handler()
        {
            Console.WriteLine("Event received by the Program class.");
        }
        static void Main(string[] args)
        {
            MyEvent evt = new MyEvent();
            X objX = new X();
            Y objY = new Y();

            // Add handlers to the event list.
            // "Subscribed" to the event.
            evt.SomeEvent += Handler;
            evt.SomeEvent += objX.Xhandler;
            evt.SomeEvent += objY.Yhandler;

            // We generate an event
            evt.OnSomeEvent();
            Console.WriteLine();

            // We remove one handler.
            // "Unsubscribed" from the event
            evt.SomeEvent -= objX.Xhandler;
            evt.OnSomeEvent();
        }
    }
}