using System;

namespace Midterm
{
    class Rec : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public double area() => Height * Width;
        override public String ToString() => $"Rectangle of sides {Height} x {Width}";
    }
}
