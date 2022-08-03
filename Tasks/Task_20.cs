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
		
        //Define constructor that gets enumerable or array of rectangles. Constructor should assign them to its field
        public ArrayRectangles(IEnumerable<Rectangle> rectangles)
        {
            rectangle_array = rectangles.ToArray();
        }
		
        //Define public method 'AddRectangle' that adds rectangle on the first empty place of array field. Returns true if array has empty space, if not
        public bool AddRectangle(Rectangle rectangle)
        {
            for (int i = 0; i < rectangle_array.Length; i++)
            {
                if (rectangle_array[i] == null)
                {
                    rectangle_array[i] = rectangle;
                    return true;
                }
            }
            return false;
        }
		
        //Define public method 'NumberMaxArea' that returns number of rectangle with max value of area. Numbering starts from 0
        public int NumberMaxArea()
        {
            int maxArea = 0;

            for (int i = 1; i < rectangle_array.Length; i++)
            {
                if (rectangle_array[i].Area() > rectangle_array[maxArea].Area())
                {
                    maxArea = i;
                }
            }
            return maxArea;
        }
		
        //Define public method 'NumberMinPerimeter' that returns number of rectangle with min value of perimeter. Numbering starts from 0
        public int NumberMinPerimeter()
        {
            int minPerim = 0;

            for (int i = 1; i < rectangle_array.Length; i++)
            {
                if (rectangle_array[i].Perimeter() < rectangle_array[minPerim].Perimeter())
                {
                    minPerim = i;
                }
            }
            return minPerim;
        }
		
        //Define public method 'NumberSquare' that returns amount of squares in array of rectangles
        public int NumberSquare()
        {
            int numSquare = 0;

            foreach (var array in rectangle_array.Where(rectangle_array => rectangle_array.IsSquare()))
            {
                numSquare++;
            }
            return numSquare;
        }
    }
}
