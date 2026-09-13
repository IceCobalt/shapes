namespace shapes {
    internal class Program {
        static void Main( string[] args ) {
            Console.WriteLine("Wanna make some shapes? Y/N\nY\nHurray!!\nMaking Shapes...\n");

            Rectangle r1 = new Rectangle();
            r1.Height = 14.5;
            r1.Width = 10;

            Console.WriteLine($"Height is {r1.Height}cm and width is {r1.Width}cm");
            Console.WriteLine($"Perimeter is {r1.CalculatePerimeter()}cm");
            Console.WriteLine($"Area is {r1.CalculateArea()}cm²");

            Rectangle r2 = new Rectangle(15,15);
            Rectangle r3 = new Rectangle(r2);

            Console.WriteLine("-----------------------------------");

            Circle c1 = new Circle();
            c1.Radius = 5;

            Console.WriteLine($"Radius is {c1.Radius}cm");
            Console.WriteLine($"Perimeter is about {c1.CalculatePerimeter(),2}cm");
            Console.WriteLine($"Area is about {c1.CalculateArea(),2}cm²");

            Circle c2 = new Circle(7);
            Console.WriteLine($"Radius is {c2.Radius}cm");
            Console.WriteLine($"Perimeter is about {c2.CalculatePerimeter(),2}cm");
            Console.WriteLine($"Area is about {c2.CalculateArea(),2}cm²");
            
            Circle c3 = new Circle(c2);
            Console.WriteLine($"Radius is {c3.Radius}cm");
            Console.WriteLine($"Perimeter is about {c3.CalculatePerimeter(),2}cm");
            Console.WriteLine($"Area is about {c3.CalculateArea(),2}cm²");

            Console.WriteLine("-----------------------------------");

            Square s1 = new Square();
            s1.sideLength = 5;

            Console.WriteLine($"Sides are {s1.sideLength}cm long");
            Console.WriteLine($"Perimeter is {s1.CalculatePerimeter()}cm");
            Console.WriteLine($"Area is {s1.CalculatePerimeter()}cm²");

            Square s2 = new Square(6);

            Console.WriteLine($"Sides are {s2.sideLength}cm long");
            Console.WriteLine($"Perimeter is {s2.CalculatePerimeter()}cm");
            Console.WriteLine($"Area is {s2.CalculatePerimeter()}cm²");

            Square s3 = new Square(s2);

            Console.WriteLine($"Sides are {s3.sideLength}cm long");
            Console.WriteLine($"Perimeter is {s3.CalculatePerimeter()}");
            Console.WriteLine($"Area is {s3.CalculatePerimeter()}cm²");
            
            Console.WriteLine("-----------------------------------");

            Triangle t1 = new Triangle();
            t1.Base = 5;
            t1.Height = 7;
            t1.sideLength1 = 10;
            t1.sideLength2 = 11;
            t1.sideLength3 = 12;

            Console.WriteLine($"Base: {t1.Base}cm\nHeight: {t1.Height}cm\nSide 1: {t1.sideLength1}cm\nSide 2: {t1.sideLength2}cm\nSide 3: {t1.sideLength3}cm");
            Console.WriteLine($"Perimeter is {t1.CalculatePerimeter()}cm");
            Console.WriteLine($"Area is {t1.CalculateArea()}cm²");

            Triangle t2 = new Triangle(8,3,5,2,7);
            Console.WriteLine($"Base: {t2.Base}cm\nHeight: {t2.Height}cm\nSide 1: {t2.sideLength1}cm\nSide 2: {t2.sideLength2}cm\nSide 3: {t2.sideLength3}cm");
            Console.WriteLine($"Perimeter is {t2.CalculatePerimeter()}cm");
            Console.WriteLine($"Area is {t2.CalculateArea()}cm²");

            Triangle t3 = new Triangle(t2);
            Console.WriteLine($"Base: {t3.Base}cm\nHeight: {t3.Height}cm\nSide 1: {t3.sideLength1}cm\nSide 2: {t3.sideLength2}cm\nSide 3: {t3.sideLength3}cm");
            Console.WriteLine($"Perimeter is {t3.CalculatePerimeter()}cm");
            Console.WriteLine($"Area is {t3.CalculateArea()}cm²");
        }
    }
}
