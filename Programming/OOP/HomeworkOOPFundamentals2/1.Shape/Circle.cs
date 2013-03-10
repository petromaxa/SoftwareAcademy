using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.Shape
{
    class Circle : Shape
    {
        //Constructors
        public Circle(double diameter)
            : base(diameter, diameter)
        {
        }

        public Circle(double width, double height)
            :base (width, height)
        {
            if (width != height)
            {
                throw new ArgumentException("The width and the height of the circle must be equal!");
            }
        }

        //Method
        public override double CalculateSurface()
        {
            double surface = 0;
            surface = Math.PI * width / 2 * width / 2; //PI*radius^2
            return surface;
        }
    }
}
