using System;
namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            Version1();
            Version2();

            Console.ReadLine();
        }
        private static void Version1()
        {
            Circle circle = new Circle
            {
                Radius = 1.0
            };

            Square square = new Square
            {
                Side = 1.0
            };

            Rectangle rectangle = new Rectangle
            {
                Height = 1.0,
                Width = 2.0
            };

            Triangle triangle = new Triangle
            {
                Side = 2.0
            };


            Geometry geometry = new Geometry();
            Console.WriteLine($"geometry of {circle}, {square}, and {rectangle}");
            Console.WriteLine($"Area of a circle of radius {circle.Radius} is {geometry.Area(circle)}");
            Console.WriteLine($"Area of a square of side {square.Side} is {geometry.Area(square)}");
            Console.WriteLine($"Area of a rectangle {rectangle.Height} x {rectangle.Width} is {geometry.Area(rectangle)}");
            Console.WriteLine($"Area of a triangle of side {triangle.Side} is {geometry.Area(triangle)}");
        }
        private static void Version2()
        {
            Cir circle = new Cir
            {
                Radius = 1.0
            };

            Squ square = new Squ
            {
                Side = 1.0
            };

            Rec rectangle = new Rec
            {
                Height = 1.0,
                Width = 2.0
            };

            Tri triangle = new Tri
            {
                Side = 2.0
            };

            Console.WriteLine($"geometry of {circle}, {square}, and {rectangle}");
            Console.WriteLine($"Area of a circle of radius {circle.Radius} is {circle.area()}");
            Console.WriteLine($"Area of a square of side {square.Side} is {square.area()}");
            Console.WriteLine($"Area of a rectangle {rectangle.Height} x {rectangle.Width} is {rectangle.area()}");
            Console.WriteLine($"Area of a triangle of side {triangle.Side} is {triangle.area()}");

        }
    }
}
