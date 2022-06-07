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

            //Jagged multi-dimensional array
            Random random2 = new Random();

            int[][][] myArray2 = new int[random2.Next(3, 6)][][];

            for (int c = 0; c < myArray2.Length; c++)
            {
                myArray2[c] = new int[random2.Next(2, 6)][];

                for (int d = 0; d < myArray2[c].Length; d++)
                {
                    myArray2[c][d] = new int[random2.Next(2, 6)];

                    for (int e = 0; e < myArray2[c][d].Length; e++)
                    {
                        myArray2[c][d][e] = random2.Next(100);
                    }
                }
            }

            for (int c = 0; c < myArray2.Length; c++)
            {
                Console.WriteLine("Page №: " + (c + 1));

                for (int d = 0; d < myArray2[c].Length; d++)
                {
                    for (int e = 0; e < myArray2[c][d].Length; e++)
                    {
                        Console.Write(myArray2[c][d][e] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine();
			
			//Multi-dimensional array
            Random random3 = new Random();

            int[,,,] myArray3 = new int[3, 2, 3, 5];

            for (int i = 0; i < myArray3.GetLength(0); i++)
            {
                for (int j = 0; j < myArray3.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray3.GetLength(2); k++)
                    {
                        for (int l = 0; l < myArray3.GetLength(3); l++)
                        {
                            myArray3[i, j, k, l] = random3.Next(100);
                        }
                    }
                }
            }

            for (int i = 0; i < myArray3.GetLength(0); i++)
            {
                Console.WriteLine("==Book №: " + (i + 1) + "==");

                for (int j = 0; j < myArray3.GetLength(1); j++)
                {
                    Console.WriteLine("Page №: " + (j + 1));
                    for (int k = 0; k < myArray3.GetLength(2); k++)
                    {
                        for (int l = 0; l < myArray3.GetLength(3); l++)
                        {
                            Console.Write(myArray3[i,j,k,l] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}