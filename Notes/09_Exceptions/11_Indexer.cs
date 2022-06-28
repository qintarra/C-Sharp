using System;
namespace Indexer_1
{
    class TempRecord
    {
        // An array of temperature values
        private int[] temps = { 12, 16, 15, 16, 18, 16, 14 };
        // Public methods
        public void PrintTemps()
        {
            foreach (int temp in temps)
                Console.Write($"{temp} ");
            Console.WriteLine();
        }
        public int GetByIndex(int index)
        {
            return temps[index];
        }
        public void SetByIndex(int index, int value)
        {
            temps[index] = value;
        }
        // Public property
        public int First
        {
            get
            {
                return temps[0];
            }
            set
            {
                temps[0] = value;
            }
        }
        // Indexer to access the array
        public int this[int index]
        {
            get
            {
                return temps[index];
            }
            set
            {
                temps[index] = value;
            }
        }
        // Property that returns the number of array elements (read-only)
        public int Length
        {
            get { return temps.Length; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TempRecord tr = new TempRecord();
            tr.PrintTemps();
            Console.WriteLine("temps[2] = {0}", tr.GetByIndex(2));
            tr.SetByIndex(2, 20);
            tr.PrintTemps();
            Console.WriteLine("temps[0] = {0}", tr.First);
            tr.First = 15;
            tr.PrintTemps();
            // Getting values through the indexer
            Console.WriteLine("temps[1] = {0}", tr[1]);
            // Setting values through an indexer
            tr[1] = 15;
            tr[5] = 17;
            // Getting values through the indexer
            for (int i = 0; i < tr.Length; i++)
            {
                Console.Write("{0} ", tr[i]);
            }
            Console.WriteLine();
        }
    }
}