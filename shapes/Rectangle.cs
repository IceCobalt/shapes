using System;
using System.Collections.Generic;
using System.Text;

namespace shapes {
    public class Rectangle {
        //Attributes
        public double Height;
        public double Width;

        //Constructor
        //Default Constructor
        public Rectangle() {
            Console.WriteLine("A new rectangle touches the beacon");
            Height = 0;
            Width = 0;
        }
        //Parameterized Constructor
        public Rectangle(double width, double height) {
            Console.WriteLine("A new rectangle touches the beacon with intent");
            Height = height;
            Width = width;
        }
        //Copy Constructor
        public Rectangle(Rectangle r) {
            Console.WriteLine("A familiar rectangle touches the beacon");
            Height = r.Height;
            Width = r.Width;
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
