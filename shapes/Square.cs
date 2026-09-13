using System;
using System.Collections.Generic;
using System.Text;

namespace shapes {
    internal class Square {
        //Attributes
        public double sideLength;
        //Constructors
        public Square() {
            sideLength = 0;
            Console.WriteLine($"A new square, yet to form, touches the beacon");
        }
        public Square(double sidelength) {
            sideLength = sidelength;
            Console.WriteLine($"A new square, with sides {sideLength} long, touches the beacon");
        }
        public Square(Square original) {
            sideLength = original.sideLength;
            Console.WriteLine($"A familiar square, with sides {sideLength} long, touches the beacon");
        }
        //Methods
        public double CalculatePerimeter() {
            return sideLength * 4;
        }
        public double CalculateArea() {
            return sideLength * sideLength; //could do Math.Pow(sideLength, 2); but this looks cleaner imo
        }
    }
}
