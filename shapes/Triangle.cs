using System;
using System.Collections.Generic;
using System.Text;

namespace shapes {
    internal class Triangle {
        //Attributes
        public double Base;
        public double Height;
        public double sideLength1;
        public double sideLength2;
        public double sideLength3;
        //Constructors
        public Triangle() {
        Base = 0;
        Height = 0;
        sideLength1 = 0;
        sideLength2 = 0;
        sideLength3 = 0;
        Console.WriteLine($"A new Triangle, yet to form, touches the beacon");
        }
        public Triangle(double @base, double height, double sidelength1, double sidelength2, double sidelength3) {
            Base = @base; //apparently 'base' is a reserved name, but i can ignore it with @ according to google (great!)
            Height = height;
            sideLength1 = sidelength1;
            sideLength2 = sidelength2;
            sideLength3 = sidelength3;
            Console.WriteLine($"A new Triangle, with many attributes, touches the beacon");
        }
        public Triangle(Triangle T) {
            Base = T.Base;
            Height = T.Height;
            sideLength1 = T.sideLength1;
            sideLength2 = T.sideLength2;
            sideLength3 = T.sideLength3;
            Console.WriteLine($"A similar Triangle, with many attributes, touches the beacon");
        }
        //Methods
        public double CalculatePerimeter() {
            return sideLength1 + sideLength2 + sideLength3;
        }
        public double CalculateArea() {
            return Math.Round(Base * Height,2);
        }
    }
}
