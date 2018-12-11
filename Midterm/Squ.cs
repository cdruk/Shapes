using System;

namespace Midterm
{
    class Squ : Shape
    {
        public double Side { get; set; }
        public double perimeter() => 4 * Side;
        public double area() => Side * Side;
        override public String ToString() => $"Square of side {Side}";
    }
}
