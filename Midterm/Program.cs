
using System;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.Radius = 1.0;

            Square square = new Square();
            square.Side = 1.0;

            Rectangle rectangle = new Rectangle();
            rectangle.Height = 1.0;
            rectangle.Width = 2.0;

            var fork = new Fork(5.0);

            Geometry geometry = new Geometry();
            Console.WriteLine($"geometry of {circle}, {square}, and {rectangle}");
            Console.WriteLine($"Area of a circle of radius {circle.Radius} is {geometry.Area(circle)}");
            Console.WriteLine($"Area of a square of side {square.Side} is {geometry.Area(square)}");
            Console.WriteLine($"Area of a rectangle {rectangle.Height} x {rectangle.Width} is {geometry.Area(rectangle)}");

            try
            {
                Console.WriteLine($"Have a {fork}");
                Console.WriteLine($"Area of a Fork {fork}  is {geometry.Area(fork)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
