using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14.QuickSortAlgorithm
{
    class QuickSortAlgorithm
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

            QuickSortArray(array,0,array.Length-1);
            Console.WriteLine("The sorted array is:");
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write("{0},", array[i]);
            }
            Console.WriteLine(array[array.Length - 1]);
        }

        static int SortPartition(int[] array, int startIndex, int endIndex)
        {
            int oldValue;
            int pivot = array[(startIndex + endIndex) / 2];
            while (startIndex <= endIndex) 
            {
                while (array[startIndex] < pivot)
                {
                    startIndex++;
                }
                while (array[endIndex] > pivot)
                {
                    endIndex--;
                }
                if (startIndex <= endIndex) 
                {
                    oldValue = array[startIndex];
                    array[startIndex] = array[endIndex];
                    array[endIndex] = oldValue;
                    startIndex++;
                    endIndex--;
                }
            }
            return startIndex;
        }
 
        static void QuickSortArray(int[] array, int startIndex, int endIndex) 
        {
            int startIndexPartition = SortPartition(array, startIndex, endIndex);
            if (startIndex < startIndexPartition - 1)
            {
                QuickSortArray(array, startIndex, startIndexPartition - 1);
            }
            if (startIndexPartition < endIndex)
            {
                QuickSortArray(array, startIndexPartition, endIndex);
            }
        }
    }
}
