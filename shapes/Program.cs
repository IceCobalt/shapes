namespace shapes {
    internal class Program {
        static void Main( string[] args ) {
            Console.WriteLine("Hello, World!");

            Rectangle r1 = new Rectangle();
            r1.Height = 14.5;
            r1.Width = 10;

            Console.WriteLine($"Height is {r1.Height} and width is {r1.Width}");
            Console.WriteLine($"Perimeter is {r1.CalculatePerimeter()}");
            Console.WriteLine($"Area is {r1.CalculateArea()}");

            Rectangle r2 = new Rectangle(15,15);
            Rectangle r3 = new Rectangle(r2);
        }
    }
}
