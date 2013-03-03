using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.PrintNumbersDivisibleBy3And7
{
    class PrintNumbersDivisibleBy3And7
    {
        static void Main()
        {
            int[] array = new int[] { 42, 3, 4, 5, 6, 7, 10, 14, 21 };

            //Find numbers divisible by 3 and 7 with Lambda expression
            var numbersDivisibleBy3And7Lambda = array.Where(number => number % 3 == 0 && number % 7 == 0).Select(number => number);
            
            //Print results with Lambda expression
            foreach (var number in numbersDivisibleBy3And7Lambda)
            {
                Console.Write("{0} ",number);
            }
            Console.WriteLine();

            //Find numbers divisible by 3 and 7 with LINQ
            var numbersDivisibleBy3And7LINQ =
                from number in array
                where number % 3 == 0 && number % 7 == 0
                select number;

            //Print results with LINQ
            foreach (var number in numbersDivisibleBy3And7LINQ)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();
        }
    }
}
