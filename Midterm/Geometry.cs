using System;

namespace Midterm
{
    class Geometry
    {
        public readonly double Pi = 3.14159265;
        public double Area(Object shape)
        {
            if (shape is Circle)
            {
                Circle cir = (Circle)shape;
                return Pi * cir.Radius * cir.Radius;
            }
            else if (shape is Square)
            {
                Square squ = (Square)shape;
                return squ.Side * squ.Side;
            }
            else if (shape is Rectangle)
            {
                Rectangle rec = (Rectangle)shape;
                return rec.Height * rec.Width;
            }
            throw new Exception("No such shape");
        }
    }
}
