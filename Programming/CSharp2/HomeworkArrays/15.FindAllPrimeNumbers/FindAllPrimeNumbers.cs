using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15.FindAllPrimeNumbers
{
    class FindAllPrimeNumbers
    {
        static void Main()
        {
            bool[] numbers = new bool[10000000];
            for (int i = 0; i < 10000000; i++)
            {
                numbers[i] = true;
            }

            for (int i = 2; i < Math.Sqrt(10000000); i++)
            {
                if (numbers[i] == true)
                {
                    Console.WriteLine(i);
                    for (int j = i * i; j < 10000000; j=j+i)
                    {
                        if (j % i == 0)
                        {
                            numbers[j] = false;
                        }
                    }
                }
            }

            for (int i = (int)Math.Sqrt(10000000); i < 10000000; i++)
            {
                if (numbers[i])
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
