using System;
namespace Interface_1
{
    interface IArea
    {
        double GetArea();
    }
    class Rectangle : IArea
    {
        private double width;
        private double height;
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public double GetArea()
        {
            return width * height;
        }
    }
    class Garden : IArea
    {
        double area;
        public Garden(double area)
        {
            this.area = area;
        }
        public double GetArea()
        {
            return area;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(4, 5);
            Console.WriteLine("Area of the rectangle = {0} sq.cm.", r.GetArea());
            Garden g = new Garden(600);
            Console.WriteLine("Garden area = {0} sq.m.", g.GetArea());
        }
    }
}