using System;
/* An aggregation is a specialized form of association
 * between two or more objects in which each object has its own life cycle
 * but there exists ownership as well.
 * Their lifetimes are unrelated
 * (for example, the component is passed through the parameters of the constructor)
 */

namespace OOP_Aggregation
{
    class Point
    {
        public string Name { get; }
        public double X { get; }
        public double Y { get; }
        public Point(string name, double x, double y)
        {
            Name = name;
            X = x;
            Y = y;
        }
        // Method for calculating the distance to another point
        public double Distance(Point C)
        {
            return Math.Sqrt((this.X - C.X) * (X - C.X) + (Y - C.Y) * (Y - C.Y));
        }
        public void Info()
        {
            Console.WriteLine($"Point {Name} coordinates x = {X} y = {Y}");
        }
    }

    class Segment
    {
        Point A, B;
        public Segment(Point A, Point B)
        {
            this.A = A;
            this.B = B;
        }
        // Static method for calculating the length of a segment
        public static double Length(Point H, Point K)
        {
            return H.Distance(K);
        }
        // Instance method for calculating the length of a segment
        public double Length()
        {
            return A.Distance(B);
        }
    }

    class Triangle
    {
        public string Name { get; }
        private Point A, B, C;
        public Triangle(Point A, Point B, Point C)
        {
            Name = A.Name + B.Name + C.Name;
            this.A = A;
            this.B = B;
            this.C = C;
        }
        // Method for calculating the perimeter of a triangle
        public double Perimetr()
        {
            return Segment.Length(A, B) + Segment.Length(B, C) + Segment.Length(C, A);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point("A", 0, 0);
            Point B = new Point("B", 3, 0);
            Point C = new Point("C", 0, 4);
            A.Info();
            B.Info();
            C.Info();
            Triangle ABC = new Triangle(A, B, C);
            Console.WriteLine($"The perimeter of the triangle {ABC.Name} is { ABC.Perimetr()}");

            ABC = null;

            if (ABC == null)
            {
                Console.WriteLine("Instance does not exist");
            }
            else
            {
                Console.WriteLine($"The perimeter of the triangle {ABC.Name} is { ABC.Perimetr()}");
            }
            A.Info();
            B.Info();
            Segment AB = new Segment(A, B);
            Console.WriteLine($"The length of the segment AB is equal to {AB.Length()}");
        }
    }
}