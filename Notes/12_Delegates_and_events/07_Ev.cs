using System;
namespace Event_1
{
    // Let's introduce our own delegate that does not take any values.
    delegate void MyDelegate();
    // This is a test class, it is a hypothetical button component.
    class Button
    {
        // Let's introduce a public event, to which everyone can join.
        public event MyDelegate Click;
        // This function is required in order to simulate a button click event.
        public void SimulateClick()
        {
            // We call the functions associated with the Click event,
            // having previously checked whether anyone has registered for this event.
            if (Click != null)
                Click();
        }
    }
	
    class Program
    {
        // This is the button click event handler function.
        static void Handler()
        {
            Console.WriteLine("Who pressed the button ?!!!");
        }
        static void Main()
        {
            // Create an instance of the class / component.
            Button sc = new Button();
            // Add a handler to its event.
            sc.Click += Handler;
            // Let’s call the function that initiates the event of pressing the button.
            sc.SimulateClick();
        }
    }
}