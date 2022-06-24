using System;
namespace OOP_12_5
{
    abstract class Shape
    {
        public string Name { get; }
        // "abstract" classes should not have "public" constructors
        protected Shape(string name)
        {
            Name = name;
        }
        public void Info()
        {
            Console.WriteLine("This is {0} and its area is {1:#.##}", Name, Area());
        }
        public abstract double Area();
    }
    class Triangle : Shape
    {
        double a, b, c;
        public Triangle(double a, double b, double c, string name) : base(name)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
    class Rectangle : Shape
    {
        double a, b;
        public Rectangle(double a, double b, string name) : base(name)
        {
            this.a = a;
            this.b = b;
        }
        public override double Area()
        {
            return a * b;
        }
    }
    class Circle : Shape
    {
        double r;
        public Circle(double r, string name) : base(name)
        {
            this.r = r;
        }
        public override double Area()
        {
            return Math.PI * r * r;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(2, "circle");
            Rectangle rectangle1 = new Rectangle(3, 4, "rectangle1");
            Rectangle rectangle2 = new Rectangle(2, 5, "rectangle2");
            Triangle triangle = new Triangle(3, 4, 5, "right triangle");

            Shape[] shapes = { circle, rectangle1, rectangle2, triangle };
            foreach (Shape s in shapes)
            {
                s.Info();
            }
        }
    }
}