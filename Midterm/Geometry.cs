using System;

namespace Midterm
{
    class Geometry
    {
        public readonly double Pi = 3.14159265;
        public double Perimeter(Object shape)
        {
            if (shape is Circle cir)
            {
                return 2 * Pi * cir.Radius;
            }
            else if (shape is Square squ)
            {
                return 4 * squ.Side;
            }
            else if (shape is Rectangle rec)
            {
                return 2 * rec.Height + 2 * rec.Width;
            }
            else if (shape is Triangle tri)
            {
                return 3 * tri.Side;
            }
            throw new Exception("No such shape");
        }
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
