using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Using your own class for event arguments
namespace Event_6
{
    class SunEventArgs : EventArgs
    {
        public DateTime DT { get; private set; }
        public string Place { get; private set; }
        public string Message { get; private set; }
        public SunEventArgs(DateTime dt, string place, string message)
        {
            DT = dt;
            Place = place;
            Message = message;
        }
    }
    class Sun
    {
        public event EventHandler<SunEventArgs> Sunrise;
        public void OnSunrise(DateTime dt, string place, string message)
        {
            Console.WriteLine($"The sun is up {place}");
            Sunrise?.Invoke(this, new SunEventArgs(dt, place, message));
        }
    }
    class Observer
    {
        string name;
        public Observer(string name)
        {
            this.name = name;
        }
        public void Handler(object sender, SunEventArgs e)
        {
            Console.WriteLine($"{name} says: {e.Message} {e.DT.ToShortDateString()} { e.Place}!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sun sun = new Sun();
            Observer girl = new Observer("Helena");
            Observer boy = new Observer("Jacob");
            sun.Sunrise += new EventHandler<SunEventArgs>(girl.Handler);
            sun.Sunrise += new EventHandler<SunEventArgs>(boy.Handler);
            sun.OnSunrise(DateTime.Now.AddDays(-7), "in Barselona", "What a beautiful sunrise");
            sun.OnSunrise(DateTime.Now.AddDays(-3), "in Prague", "What a wonderful sunrise");
            sun.OnSunrise(DateTime.Now.AddDays(-1), "in Kiev", "What a fabulous sunrise");
        }
    }
}