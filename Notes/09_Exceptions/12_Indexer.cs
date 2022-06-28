using System;
namespace Indexer_3
{
    public class ArrayException : Exception
    {
        public ArrayException(String message) : base(message) { }
        public ArrayException(String message, Exception inner) : base(message, inner) { }
    }
    class DemoArray
    {
        private int[,] myArray;//private field
        public int LengthN { get; } //property that returns the number of rows
        public int LengthM { get; } //property that returns the number of columns
        public DemoArray(int sizeN, int sizeM)//constructor
        {
            myArray = new int[sizeN, sizeM];
            LengthN = sizeN;
            LengthM = sizeM;
        }
        public int this[int i, int j] //indexer
        {
            get
            {
                if (i < 0 || i >= LengthN || j < 0 || j >= LengthM)
                    throw new ArrayException("index is not correct");
                else return myArray[i, j];
            }
            set
            {
                if (i < 0 || i >= LengthN || j < 0 || j >= LengthM)
                    throw new ArrayException("index is not correct");
                else
                if (value >= 0 && value <= 100) myArray[i, j] = value;
                else
                    throw new ArrayException("an invalid value is assigned");
            }
        }
    }
    class Program
    {
        static void Main()
        {
            DemoArray a = new DemoArray(3, 3);
            Random r = new Random();
            for (int i = 0; i < a.LengthN; i++, Console.WriteLine())
            {
                for (int j = 0; j < a.LengthM; j++)
                {
                    a[i, j] = r.Next(10, 99); // use the indexer in writing mode
                    Console.Write("{0,3}", a[i, j]);// use the indexer in reading mode
                }
            }
            Console.WriteLine();
            try
            {
                Console.WriteLine(a[2, 2]);
                a[0, 1] = 99;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("New array:");
            for (int i = 0; i < a.LengthN; i++)
            {
                for (int j = 0; j < a.LengthM; j++)
                {
                    Console.Write("{0,3}", a[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}