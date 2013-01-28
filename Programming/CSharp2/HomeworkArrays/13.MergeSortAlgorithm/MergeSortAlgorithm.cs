using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13.MergeSortAlgorithm
{
    class MergeSortAlgorithm
    {
        static void Main()
        {
            bool isCorrectEntry = true;
            Console.WriteLine("Enter the elements of the array separated by \",\":");
            string[] stringArray = Console.ReadLine().Split(',');
            int[] array = new int[stringArray.Length];

            for (int i = 0; i < stringArray.Length; i++)
            {
                isCorrectEntry = int.TryParse(stringArray[i], out array[i]);
                if (isCorrectEntry == false)
                {
                    Console.WriteLine("Wrong entry!");
                    return;
                }
            }

            MergeSortArray(array, 0, array.Length-1);
            Console.WriteLine("The sorted array is:");
            for (int i = 0; i < array.Length-1; i++)
            {
                Console.Write("{0},",array[i]);
            }
            Console.WriteLine(array[array.Length - 1]);
        }

        static void MergeSortArray(int[] array, int startIndex, int endIndex)
        {
            if (startIndex < endIndex)
            {
                int middleIndex =(startIndex + endIndex) / 2;
                MergeSortArray(array, startIndex, middleIndex);
                MergeSortArray(array, middleIndex + 1, endIndex);
                MergeSortPartition(array, startIndex, endIndex);
            }
        }

        static void MergeSortPartition(int[] array, int startIndex, int endIndex) 
        { 
            int middleIndex = (startIndex + endIndex) / 2; 
            int tempArrayIndex = 0; 
            int leftHalfIndex = startIndex; 
            int righHalftIndex = middleIndex + 1; 

            int[] tempArray = new int[endIndex-startIndex+1];

            while (leftHalfIndex <= middleIndex && righHalftIndex <= endIndex)
            {
                if (array[leftHalfIndex] < array[righHalftIndex])
                {
                    tempArray[tempArrayIndex++] = array[leftHalfIndex++];
                }
                else
                {
                    tempArray[tempArrayIndex++] = array[righHalftIndex++];
                }
            }

            while (leftHalfIndex <= middleIndex)
            {
                tempArray[tempArrayIndex++] = array[leftHalfIndex++];
            }

            while (righHalftIndex <= endIndex)
            {
                tempArray[tempArrayIndex++] = array[righHalftIndex++];
            }

            for (int i = startIndex; i <= endIndex; i++)
            {
                array[i] = tempArray[i - startIndex];
            }
        }
    }
}
