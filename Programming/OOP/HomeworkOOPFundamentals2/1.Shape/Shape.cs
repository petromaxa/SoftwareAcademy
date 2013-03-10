using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.Shape
{
    abstract class Shape
    {
        //Fields
        protected double width;
        protected double height;

        //Constructor
        public Shape(double width, double height)
        {
            //Check the width
            if (width <= 0)
            {
                throw new ArgumentException("The width of the shape cannot be negative or 0!");
            }
            else
	        {
                this.width = width;
	        }

            //Check the height
            if (height <= 0)
            {
                throw new ArgumentException("The height of the shape cannot be negative or 0!");
            }
            else
	        {
                this.height = height;
	        }
        }


        //Properties
        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The height of the figure cannot be negative or 0!");
                }
                else
                {
                    this.height = value;
                } 
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The width of the figure cannot be negative or 0!");
                }
                else
                {
                    this.width = value;
                }
            }
        }

        //Method
        public virtual double CalculateSurface()
        {
            Console.WriteLine("I don't know how to calculate my surface!");
            return 0;
        }
    }
}
