using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _21.CombinationsInNofK
{
    class CombinationsInNofK
    {
        static void Main()
        {
            bool isCorrectEntry = true;
            int N = 0;
            int K = 0;
            Console.Write("Enter N:");
            isCorrectEntry = int.TryParse(Console.ReadLine(), out N);
            if (isCorrectEntry == false || (isCorrectEntry && N <= 0))
            {
                Console.WriteLine("Wrong entry!");
                return;
            }

            Console.Write("Enter K:");
            isCorrectEntry = int.TryParse(Console.ReadLine(), out K);
            if (isCorrectEntry == false || (isCorrectEntry && K <= 0))
            {
                Console.WriteLine("Wrong entry!");
                return;
            }
            int[] array = new int[K];
            int decreaseNumbers=0;
            FindCombinations(array, 0, N, K, decreaseNumbers);
        }

        static void FindCombinations(int[] array, int position, int N, int K, int decreaseNumbers)
        {
            if (position == K)
            {
                for (int i = 0; i < K; i++)
                {
                    Console.Write("{0} ", array[i]);
                }
                Console.WriteLine();
                return;
            }

            for (int counter = decreaseNumbers+1; counter <= N; counter++)
            {
                array[position] = counter;
                FindCombinations(array, position + 1, N, K, decreaseNumbers);
                decreaseNumbers++;
            }
        }
    }
}
