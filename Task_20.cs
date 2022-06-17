using System;
using System.Collections.Generic;
using System.Linq;

namespace Class
{
    //Create public class Rectangle here
    class Rectangle
    {
        //Define two private double fields: 'sideA', 'sideB'
        private double sideA;
        private double sideB;
		
        //Define constructor with two double parameters: 'a', 'b'. Assign parameters to sides
        public Rectangle(double a, double b)
        {
            sideA = a;
            sideB = b;
            return;
        }
		
        //Define constructor with double parameter: 'a'. Parameter sets side A of rectangle, and B-side always equals 5
        public Rectangle (double a)
        {
            sideA = a;
            sideB = 5;
        }
		
        //Define constructor without parameters. A-side of rectangle equals 4, B-side - 3
        public Rectangle()
        {
            sideA = 4;
            sideB = 3;
        }
		
        //Define public method 'GetSideA' that returns value of A-side
        public double GetSideA()
        {
            return sideA;
        }
		
        //Define public method 'GetSideB' that returns value of B-side
        public double GetSideB()
        {
            return sideB;
        }
		
        //Define public method 'Area' that calculates and returns value of area
		public double Area()
        {
            return sideA * sideB;
        }
		
        //Define public method 'Perimeter' that calculates and returns value of perimeter
        public double Perimeter()
        {
            return 2 * (sideA + sideB);
        }
		
        //Define public method 'IsSquare' that checks if rectangle is a square. Returns true if it is a square, false if it's not.
        public bool IsSquare()
        {
            return sideA == sideB;
        }
		
        //Define public method 'ReplaceSides' that swaps values of rectangle sides
        public void ReplaceSides()
        {
            (sideA, sideB) = (sideB, sideA);
        }
    }
    //Create public class ArrayRectangles 
    class ArrayRectangles
    {
        //Define private field that is array of rectangles: 'rectangle_array'
        private readonly Rectangle [] rectangle_array;
		
        //Define constructor with int parameter: 'n'. Constructor should create an empty array of rectangles with length of 'n'
        public ArrayRectangles (int n)
        {
            rectangle_array = new Rectangle[n];
        }
    }
}
