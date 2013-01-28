using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.MaxSumOfKElementsInArray
{
    class MaxSumOfKElementsInArray
    {
        static void Main()
        {
            int N = 0;
            int K = 0;
            int maxSum = 0;
            bool isCorrectEntry = true;
            Console.Write("Enter N:");
            isCorrectEntry = int.TryParse(Console.ReadLine(), out N);
            if (isCorrectEntry == false)
            {
                Console.WriteLine("Wrong entry!");
                return;
            }

            Console.Write("Enter K:");
            isCorrectEntry = int.TryParse(Console.ReadLine(), out K);
            if (isCorrectEntry == false)
            {
                Console.WriteLine("Wrong entry!");
                return;
            }
            
            int[] array = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Enter the {0} element of the array:", i);
                isCorrectEntry = int.TryParse(Console.ReadLine(), out array[i]);
                if (isCorrectEntry == false)
                {
                    Console.WriteLine("Wrong entry!");
                    return;
                }
            }

            Array.Sort(array);
            for (int i = N - 1; i >= N - K; i--)
            {
                maxSum = maxSum + array[i];
            }
            Console.Write("The {0} elements of the array that have maximal sum={1} are: ",K,maxSum);
            for (int i = N - 1; i >= N - K + 1; i--)
            {
                Console.Write("{0},", array[i]);
            }
            Console.Write("{0}\n", array[N-K]);
        }
    }
}
