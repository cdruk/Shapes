using System;

namespace Midterm
{
    class Geometry
    {
        public readonly double Pi = 3.14159265;
        public double Area(Object shape)
        {
            if (shape is Circle cir)
            {
                return Pi * cir.Radius * cir.Radius;
            }
            else if (shape is Square squ)
            {
                return squ.Side * squ.Side;
            }
            else if (shape is Rectangle rec)
            {
                return rec.Height * rec.Width;
            }
            else if (shape is Triangle tri)
            {
                return Math.Sqrt(3) / 4 * Math.Pow(tri.Side, 2);
            }
            throw new Exception("No such shape");
        }
    }
}
