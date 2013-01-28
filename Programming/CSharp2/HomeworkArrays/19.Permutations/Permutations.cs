using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _19.Permutations
{
    class Permutations
    {
       static void Main()
       {
            bool isCorrectEntry = true;
            int N = 0;

            Console.Write("Enter the size of the array N:");
            isCorrectEntry = int.TryParse(Console.ReadLine(), out N);
            if (isCorrectEntry == false || (isCorrectEntry && N <= 0))
            {
                Console.WriteLine("Wrong entry!");
                return;
            }

            int[] array = new int[N];
            for (int i = 0; i < N; i++)
            {
                array[i] = i + 1;
            }

            FindPermutations(array, 0, N);
        }

       private static void FindPermutations(int[] array, int permPosition, int N)
        {
            if (permPosition == N - 1)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("{0} ", array[i]);
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = permPosition; i < N; i++)
                {
                    int oldValue = array[i];
                    array[i] = array[permPosition];
                    array[permPosition] = oldValue;
                    FindPermutations(array, permPosition + 1, N);
                    array[permPosition] = array[i];
                    array[i] = oldValue;
                }
            }
        }
    }
}
