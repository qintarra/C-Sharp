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
    }
}