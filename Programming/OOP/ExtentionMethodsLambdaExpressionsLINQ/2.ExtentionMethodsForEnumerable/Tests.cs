using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.ExtentionMethodsForEnumerable
{
    class Tests
    {
        static void Main()
        {
            List<double> newList = new List<double>();
            newList.Add(1);
            newList.Add(2);
            newList.Add(3);
            newList.Add(4);
            newList.Add(5);
            Console.WriteLine("Elements:");
            for (int i = 0; i < newList.Count; i++)
            {
                Console.WriteLine("newList[{0}] = {1}",i,newList[i]);
            }

            //Try the Sum method
            Console.WriteLine("\nThe sum of all the elements is = {0}",newList.Sum()); //15

            //Try the Product method
            Console.WriteLine("\nThe product of all the elements is = {0}", newList.Product()); //120

            //Try the Max method
            Console.WriteLine("\nThe maximal of all the elements is = {0}", newList.Max()); //5

            //Try the Min method
            Console.WriteLine("\nThe minimal of all the elements is = {0}", newList.Min()); //1

            //Try the Average method
            Console.WriteLine("\nThe average of all the elements is = {0}", newList.Average()); //3
        }
    }
}
