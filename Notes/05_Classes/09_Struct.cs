using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Struct_Point
{
    struct Point
    {
        public double x, y;
        public void PointInfo()
        {
            Console.WriteLine($"Point coordinates: x={x} y={y}");
        }
        public void MoveTo (double x1, double y1)
        {
            x = x1;
            y = y1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point p1;
            p1.x = 1;
            p1.y = 6;
            p1.PointInfo();

            Point p2;
            p2.x = 4;
            p2.y = 10;
            Console.WriteLine($"Second point coordinates x={p2.x} y={p2.y}");

            double d = Math.Sqrt(Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2));
            Console.WriteLine($"The distance between the points is {d}");

            p1.MoveTo(5, 4);
            p1.PointInfo();
        }
    }
}