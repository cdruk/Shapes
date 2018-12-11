using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Triangle
    {
        public double Side { get; set; }
        override public String ToString() => $"Equilateral Triangle of side {Side}";
    }
}
