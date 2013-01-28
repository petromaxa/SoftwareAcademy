using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.MaxSequenseOfEqualElementsInArray
{
    class MaxSequenseOfEqualElementsInArray
    {
        static void Main()
        {
            int N = 0;
            int maxSequence = 1;
            int currentSequence = 1;
            bool isCorrectEntry = true;
            Console.WriteLine("Enter size of the array:");
            isCorrectEntry = int.TryParse(Console.ReadLine(), out N);
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

            for (int i = 1; i < N; i++)
            {
                if (array[i - 1] == array[i])
                {
                    currentSequence++;
                }
                else
                {
                    if (currentSequence>maxSequence)
                    {
                        maxSequence = currentSequence;
                    }
                    currentSequence = 1;
                }
            }
            Console.WriteLine("Maximal sequence of equal elements is: {0}",maxSequence);
        }
    }
}
