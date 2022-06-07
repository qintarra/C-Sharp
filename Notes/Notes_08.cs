using System;

namespace Notes_08
{
    public static class Program
    {
        static void Main(string [] args)
        {
            //Jagged array
            int[][] myArray = new int[5][];
            myArray[0] = new int[5];
            myArray[1] = new int[3];
            myArray[2] = new int[8];
            myArray[3] = new int[6];
            myArray[4] = new int[7];

            Random random = new Random();

            for (int a = 0; a < myArray.Length; a++)
            {
                for (int j = 0; j < myArray[a].Length; j++)
                {
                    myArray[a][j] = random.Next(100);
                }
            }

            for (int a = 0; a < myArray.Length; a++)
            {
                for (int j = 0; j < myArray[a].Length; j++)
                {
                    Console.Write(myArray[a][j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            
        }
    }
}