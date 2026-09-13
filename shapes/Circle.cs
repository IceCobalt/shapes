using System;
using System.Collections.Generic;
using System.Text;

namespace shapes {
    internal class Circle {
        //Attributes
        public double Radius;

        //Constructor
        public Circle() {
            Radius = 0;
            Console.WriteLine($"A new circle, yet to form, touches the beacon");
        }

        public Circle(double R) {
            Radius = R;
            Console.WriteLine($"A new circle at about {Radius}cm touches the beacon");
        }
        public Circle(Circle original) {
            Radius = original.Radius;
            Console.WriteLine($"A familiar circle of {Radius}cm touches the beacon");
        }

        //Methods
        public double CalculateArea() {
            return Math.PI * Math.Pow(Radius,2); 
        }

        public double CalculatePerimeter() {
            return 2 * Math.PI * Radius;
        }
    }
}
