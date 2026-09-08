using System;
using System.Collections.Generic;
using System.Text;

namespace shapes {
    public class Rectangle {
        //Attributes
        public double Height;
        public double Width;

        //Constructor
        public Rectangle() {
            Console.WriteLine("A new rectangle touches the beacon");
            Height = 0;
            Width = 0;
        }

        //Methods | Functions
        public double CalculateArea() {
            return Width * Height;
        }
        public double CalculatePerimeter() {
            return (Width * 2) + (Height * 2);
        }
    }
}
