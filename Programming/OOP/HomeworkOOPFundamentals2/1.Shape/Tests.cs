using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.Shape
{
    class Tests
    {
        static void Main()
        {
            //Create an array of shapes
            Shape[] shapes = {
                                 new Rectangle(5,5),
                                 new Triangle(5,5),
                                 new Circle(5,5),
                                 new Circle(5)
                             };

            //Test the CalculateSurface methods
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.GetType().Name);
                Console.WriteLine("{0}\n",shape.CalculateSurface());
            }

            //Try the exeptions
            //Triangle newTr = new Triangle(-9,6);
            //Circle newTr = new Circle(-9);

            //Try the properties
            Circle newCircle = new Circle(9);
            Console.WriteLine("Circle Width = {0}",newCircle.Width);
            Console.WriteLine("Circle Height = {0}",newCircle.Height);
        }
    }
}
