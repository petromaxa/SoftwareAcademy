using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.Exeption
{
    class Tests
    {
        static void Main( )
        {
            
            //int number = 101;
            int number = 10;
            if (number < 0 || number > 100)
            {
                throw new InvalidRangeException<int>("The number is out of the range!",0,100);
            }


            //DateTime newDate = new DateTime(1979, 12, 20);
            DateTime newDate = new DateTime(2012, 12, 20);
            if (newDate < new DateTime(1980, 1, 1) || newDate > new DateTime(2013, 12, 31))
            {
                throw new InvalidRangeException<DateTime>("The date is out of the range!", new DateTime(1980, 1, 1), new DateTime(2013, 12, 31));
            }
        }
    }
}
