using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8.MaxSumSequenceInArray
{
    class MaxSumSequenceInArray
    {
        static void Main()
        {
            bool isCorrectEntry = true;
            int maxSum = int.MinValue;
            int runningTotal = 0;
            Console.WriteLine("Enter the elements of the array separated by \",\":");
            string[] stringArray = Console.ReadLine().Split(',');
            int[] array = new int[stringArray.Length];
            int startIndex = 0;
            int oldStartIndex = 0;
            int endIndex = 0;
            
            for (int i = 0; i < stringArray.Length; i++)
            {
                isCorrectEntry = int.TryParse(stringArray[i], out array[i]);
                if (isCorrectEntry == false)
                {
                    Console.WriteLine("Wrong entry!");
                    return;
                }
            }

            startIndex = 0;
            endIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                runningTotal += array[i];
                if (runningTotal > maxSum)
                {
                    maxSum = runningTotal;
                    startIndex = oldStartIndex;
                    endIndex = i;
                }
                if (runningTotal < 0)
                {
                    runningTotal = 0;
                    oldStartIndex = i + 1;
                }
            }

            Console.Write("The max sum subarray contans {0} elements: ", (endIndex + 1) - startIndex);
            for (int i = startIndex; i < endIndex; i++)
            {
                Console.Write("{0},", array[i]);
            }
            Console.Write("{0} ", array[endIndex]);
            Console.Write("and it has maximal sum={0}\n", maxSum);
        }
    }
}
