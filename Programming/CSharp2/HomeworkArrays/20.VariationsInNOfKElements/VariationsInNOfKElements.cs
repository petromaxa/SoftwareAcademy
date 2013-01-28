using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20.VariationsInNOfKElements
{
    class VariationsInNOfKElements
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
            FindVariations(array, 0, N, K);
        }  

        static void FindVariations(int[] array, int position, int N, int K)
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
 
            for (int counter=1; counter <= N; counter++)
            {
                  array[position] = counter;
                  FindVariations(array, position + 1,N,K);
            }
        }     
    }
}
