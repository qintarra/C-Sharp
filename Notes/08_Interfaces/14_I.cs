using System;
namespace OOP_AbstractClassAndInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new Duck("Donald", 4);
            Hen hen = new Hen("Leafie", 3);
            Ostrich ostrich = new Ostrich("Rocky", 150);
            Penguin penguin = new Penguin("Rico", 20);
            Bird[] birds = { duck, hen, ostrich, penguin };
            foreach (Bird bird in birds)
            {
                bird.AboutMe();
            }
            ISwimable[] swimables = { duck, penguin };
            Console.WriteLine("Birds that can swim:");
            foreach (var bird in swimables)
            {
                bird.Swim();
            }
        }
    }
    abstract class Bird
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public abstract void AboutMe();
    }
    interface IFlyable
    {
        void Fly();
    }
    interface ISwimable
    {
        void Swim();
    }
    interface IRunable
    {
        void Run();
    }
    class Duck : Bird, ISwimable, IFlyable, IRunable
    {
        public Duck(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }
        public override void AboutMe()
        {
            Console.WriteLine($"I am a duck {Name} and my weight reaches {Weight} kg.");
            Fly();
            Run();
            Swim();
        }
        public void Fly()
        {
            Console.WriteLine("Wild ducks fly well");
        }
        public void Run()
        {
            Console.WriteLine("The duck can run, but awkwardly, waddling");
        }
        public void Swim()
        {
            Console.WriteLine("The duck can swim and even dive");
        }
    }
    class Hen : Bird, IFlyable, IRunable
    {
        public Hen(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }
        public override void AboutMe()
        {
            Console.WriteLine($"I am a hen {Name} and my weight reaches {Weight} kg.");
            Fly();
            Run();
        }
        public void Fly()
        {
            Console.WriteLine("The hen flies badly and not far");
        }
        public void Run()
        {
            Console.WriteLine("The hen runs fast enough");
        }
    }
    class Ostrich : Bird, IRunable
    {
        public Ostrich(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }
        public override void AboutMe()
        {
            Console.WriteLine($"I am an ostrich {Name} and my weight reaches {Weight} kg.");
           
            Run();
        }
        public void Run()
        {
            Console.WriteLine("The ostrich runs, reaching speeds of up to 60-70 km/h");
        }
    }
    class Penguin : Bird, IRunable, ISwimable
    {
        public Penguin(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }
        public override void AboutMe()
        {
            Console.WriteLine($"I am a penguin {Name} and my weight reaches {Weight} kg.");
           
            Run();
            Swim();
        }
        public void Run()
        {
            Console.WriteLine("On land, penguins move, waddling from side to side");
        }
        public void Swim()
        {
            Console.WriteLine("Penguins swim and dive great");
        }
    }
}