using System;
//Using the standard 'EventHandler' delegate
namespace Event_5
{
    class Sun
    {
        public event EventHandler Sunrise;
        public void OnSunrise()
        {
            Console.WriteLine("The sun is up.");
            Sunrise?.Invoke(this, EventArgs.Empty);
        }
    }
    class Observer
    {
        string name;
        public Observer(string name)
        {
            this.name = name;
        }
        public void Handler(object sender, EventArgs e)
        {
            Console.WriteLine($"{name} says: how beautiful!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sun sun = new Sun();

            Observer girl = new Observer("Samantha");
            Observer boy = new Observer("Sam");
            sun.Sunrise += new EventHandler(girl.Handler);
            sun.Sunrise += new EventHandler(boy.Handler);

            sun.OnSunrise();
        }
    }
}