using System;
using System.Collections.Generic;
using System.Linq;
namespace OOP_12_3
{
    abstract class Shape
    {
        public string Name { get; set; }
        public void Info()
        {
            Console.WriteLine("This is {0} and its area is {1:#.##}", Name, Area());
        }
        public abstract double Area();
    }
    class Triangle : Shape
    {
        double a, b, c;
        public Triangle(double a, double b, double c)
        {
            Name = "triangle";
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
        public Rectangle(double a, double b)
        {
            Name = "rectangle";
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
        public Circle(double r)
        {
            Name = "circle";
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
            Circle circle = new Circle(2);
            Rectangle rectangle = new Rectangle(3, 4);
            Triangle triangle = new Triangle(3, 4, 5);

            Console.WriteLine("{0:#.##}", circle.Area());
            Console.WriteLine("{0:#.##}", rectangle.Area());
            Console.WriteLine("{0:#.##}", triangle.Area());

            Shape[] shapes = { circle, rectangle, triangle };
            foreach (Shape s in shapes)
            {
                s.Info();
            }
        }
    }
}
