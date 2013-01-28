using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7.SelectionSortAlgorithm
{
    class SelectionSortAlgorithm
    {

        public static int FindSmallestElement(int StartScanPosition, int[] array )
        {
            int smallestElementPosition = StartScanPosition;
            int smallestElement = array[StartScanPosition];
            for (int i = StartScanPosition + 1; i < array.Length; i++)
            {
                if (array[i] < smallestElement)
                {
                    smallestElement = array[i];
                    smallestElementPosition = i;
                }
            }
            return smallestElementPosition;
        }

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

            int arrayElementContainer=0;
            int smallestElementPosition=0;
            for (int i = 0; i < array.Length; i++)
            {
                arrayElementContainer = array[i];
                smallestElementPosition=FindSmallestElement(i, array);
                array[i] = array[smallestElementPosition];
                array[smallestElementPosition] = arrayElementContainer;
            }

            for (int i = 0; i < array.Length-1; i++)
            {
                Console.Write("{0},",array[i]);
            }
            Console.Write("{0}\n", array[array.Length-1]);
        }
    }
}
