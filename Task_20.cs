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
    }
    
}
