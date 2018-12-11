using System;

namespace Midterm
{
    class Cir : Shape
    {
        public double Radius { get; set; }
        private readonly double PI = 3.14159265;
        public double area() => PI * Radius * Radius;
        override public String ToString() => $"Circle of radius {this.Radius}";
    }
}
