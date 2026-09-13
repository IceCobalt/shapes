namespace shapes {
    internal class Program {
        static void Main( string[] args ) {
            Console.WriteLine("Wanna make some shapes? Y/N\nY\nHurray!!\nMaking Shapes...\n");

            Rectangle r1 = new Rectangle();
            r1.Height = 14.5;
            r1.Width = 10;

            Console.WriteLine($"Height is {r1.Height} and width is {r1.Width}");
            Console.WriteLine($"Perimeter is {r1.CalculatePerimeter()}");
            Console.WriteLine($"Area is {r1.CalculateArea()}");

            Rectangle r2 = new Rectangle(15,15);
            Rectangle r3 = new Rectangle(r2);

            Console.WriteLine("-----------------------------------");

            Circle c1 = new Circle();
            c1.Radius = Math.PI;

            Console.WriteLine($"Radius is {c1.Radius}");
            Console.WriteLine($"Perimeter is {c1.CalculatePerimeter()}");
            Console.WriteLine($"Area is {c1.CalculateArea()}");

            Circle c2 = new Circle(Math.E);
            Console.WriteLine($"Radius is {c2.Radius}");
            Console.WriteLine($"Perimeter is {c2.CalculatePerimeter()}");
            Console.WriteLine($"Area is {c2.CalculateArea()}");
            
            Circle c3 = new Circle(c2);
            Console.WriteLine($"Radius is {c3.Radius}");
            Console.WriteLine($"Perimeter is {c3.CalculatePerimeter()}");
            Console.WriteLine($"Area is {c3.CalculateArea()}");
        }
    }
}
