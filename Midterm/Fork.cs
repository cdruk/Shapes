using System;

namespace Midterm
{
    class Fork
    {
        public double Price { get; set; }
        public Fork()
            : this(0.0) { }

        public Fork(double price)
        {
            Price = price;
        }

        override public String ToString()
        {
            return Price == 0.0
                ? "Free Fork"
                : $"{Price} $ fork";
        }
    }
}
