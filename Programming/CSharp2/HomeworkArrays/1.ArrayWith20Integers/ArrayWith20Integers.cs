using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.ArrayWith20Integers
{
    class ArrayWith20Integers
    {
        static void Main()
        {
            int[] array = new int[20];
            for (int i = 0; i < 20; i++)
            {
                array[i] = i * 5;
                Console.WriteLine(array[i]);
            }
        }
    }
}
