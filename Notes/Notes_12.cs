using System;

namespace Notes_12.cs
{
    class Program
    {
        static int MaxElement(int[] m)
        {
            int max = m[0];
            foreach (int z in m)
                if (max < z) max = z;
            return max;
        }
		
        static void DoubleElement(int[] m)
        {
            for (int i = 0; i < m.Length; i++)
                m[i] *= 2;
        }
		
        static int[] Minus2(int [] m)
        {
            for(int i = 0; i < m.Length; i++)
                m[i] -= 2;
            return m;
        }
		
        static int SummDiag(int[,] m)
        {
            int sum = 0;
            for (int i = 0; i < m.GetLength(0); i++)
                sum += m[i, i];
            return sum;
        }
		
        static int[] DiagonalElements(int[,] m)
        {
            int d = m.GetLength(0);
            int[] aa = new int[d];
            for (int i = 0; i < aa.Length; i++)
                aa[i] = m[i, i];
            return aa;
        }
		
        static void Main(string [] args)
        {
            int[] array = { 2, 1, 3 };

            Console.WriteLine("Source array");
            foreach (int x in array)
                Console.Write("{0} ", x);


            Console.WriteLine();
            int max = MaxElement(array);
            Console.WriteLine("Maximum element = {0}", max);


            DoubleElement(array);
            Console.WriteLine("Multiply all elements of the array by 2:");
			
            foreach (int x in array)
                Console.Write("{0} ", x);
				
				
            int[] array2 = Minus2(array);

            Console.WriteLine();
            Console.WriteLine("Substract 2 from all elements of the array by 2:");

            foreach (int x in array)
                Console.Write("{0} ", x);

            Console.WriteLine();
            foreach (int x in array2)
                Console.Write("{0} ", x); //Remember about reference type of an arrays

            
        }

    }
}