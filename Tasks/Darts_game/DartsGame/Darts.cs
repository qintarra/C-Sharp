using System;
using System.Collections.Generic;

namespace DartsGame
{
    public static class Darts
    {
        public static int GetScore(double x, double y)
        {
            double r = Math.Sqrt((x * x) + (y * y));
            if (r <= 1.0)
            {
                return 10;
            }

            if (r <= 5.0)
            {
                return 5;
            }

            if (r <= 10.0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
