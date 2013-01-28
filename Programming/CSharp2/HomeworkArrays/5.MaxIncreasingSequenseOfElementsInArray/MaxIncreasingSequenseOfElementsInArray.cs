using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.MaxIncreasingSequenseOfElementsInArray
{
    class MaxIncreasingSequenseOfElementsInArray
    {
        static void Main()
        {
            int size = 0;
            int maxIncreasingSequence = 1;
            int currentSequence = 1;
            bool isCorrectEntry = true;
            Console.WriteLine("Enter size of the array:");
            isCorrectEntry = int.TryParse(Console.ReadLine(), out size);
            if (isCorrectEntry == false)
            {
                Console.WriteLine("Wrong entry!");
                return;
            }

            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter the {0} element of the array:", i);
                isCorrectEntry = int.TryParse(Console.ReadLine(), out array[i]);
                if (isCorrectEntry == false)
                {
                    Console.WriteLine("Wrong entry!");
                    return;
                }
            }

            for (int i = 1; i < size; i++)
            {
                if (array[i - 1] < array[i])
                {
                    currentSequence++;
                }
                else
                {
                    if (currentSequence > maxIncreasingSequence)
                    {
                        maxIncreasingSequence = currentSequence;
                    }
                    currentSequence = 1;
                }
            }
            Console.WriteLine("Maximal increasing sequence of elements is: {0}", maxIncreasingSequence);
        }
    }
}
