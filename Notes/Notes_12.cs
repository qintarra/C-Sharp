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
		
		
		
    }
}