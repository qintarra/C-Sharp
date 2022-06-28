using System;
using System.Collections;
namespace Collections_1
{
    class ThreePigs : IEnumerable
    {
        private string pig1; // First piglet (field number 1)
        private string pig2; // Second piglet (field number 2)
        private string pig3; // Third piglet (field number 3)
        public ThreePigs(string pig1, string pig2, string pig3)
        {
            this.pig1 = pig1;
            this.pig2 = pig2;
            this.pig3 = pig3;
        }
        public IEnumerator GetEnumerator()
        {
            yield return pig1;
            yield return pig2;
            yield return pig3;
        }
        public string this[int index]
        {
            get
            {
                switch (index)
                {
                    case 1: return pig1;
                    case 2: return pig2;
                    case 3: return pig3;
                    default: return null;
                }
            }
            set
            {
                switch (index)
                {
                    case 1: pig1 = value; break;
                    case 2: pig2 = value; break;
                    case 3: pig3 = value; break;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ThreePigs pigs = new ThreePigs("Nif-Nif", "Nuf-Nuf", "Naf-Naf");
            Console.WriteLine("Pig names:");
            foreach (var s in pigs)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine($"Name of the first pig is {pigs[1]}");
            pigs[3] = "Super Piggy";
            Console.WriteLine("Pig names:");
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine(pigs[i]);
            }
        }
    }
}