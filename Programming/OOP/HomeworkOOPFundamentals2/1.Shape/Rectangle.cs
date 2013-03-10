using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.Shape
{
    class Rectangle : Shape
    {
        //Constructor
        public Rectangle(double width, double height)
            :base (width, height)
        {
        }

        //Method
        public override double CalculateSurface()
        {
            double surface = 0;
            surface = width * height;
            return surface;
        }
    }
}
