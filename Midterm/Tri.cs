using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Tri : Shape
    {
        public double Side { get; set; }
        public double area() => Math.Sqrt(3) / 4 * Math.Pow(Side, 2);
        override public String ToString() => $"Equilateral Triangle of side {Side}";
    }
}
