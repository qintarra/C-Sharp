using System;

namespace OOP_Association_1
{
    class Boy
    {
        public string Name { get; }
        public int Growth { get; }
        public Boy(string name, int growth)
        {
            Name = name;
            Growth = growth;
        }

    }
    class Girl
    {
        public string Name { get; }
        public string Eyes { get; } //eyes color
        public Girl(string name, string eyes)
        {
            Name = name;
            Eyes = eyes;
        }
    }
    class RomanticDate
    {
        Boy boy;
        Girl girl;
        public RomanticDate(Boy boy, Girl girl)
        {
            this.boy = boy;
            this.girl = girl;
        }
        public void Result()
        {
            if(boy.Growth >= 180 && girl.Eyes == "blue")
            {
                Console.WriteLine("{0} + {1} = forever in love", boy.Name, girl.Name);
            }
            else
            {
                Console.WriteLine("{0} and {1} forever alone", boy.Name, girl.Name);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Boy boy1 = new Boy("Andy", 179);
            Console.WriteLine($"Boy's name is {boy1.Name}");

            Girl girl = new Girl("Kate", "blue");
            Console.WriteLine($"Girl's name is {girl.Name}");

            RomanticDate date1 = new RomanticDate(boy1, girl);
            date1.Result();

            Boy boy2 = new Boy("Max", 180);
            RomanticDate date2 = new RomanticDate(boy2, girl);
            date2.Result();
        }
    }
}