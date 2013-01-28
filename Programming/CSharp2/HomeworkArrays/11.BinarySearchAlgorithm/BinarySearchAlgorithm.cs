using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11.BinarySearchAlgorithm
{
    class BinarySearchAlgorithm
    {
        static void Main()
        {
            bool isCorrectEntry = true;
            int searchedNumber = 0;
            int searchedIndex = 0;
            bool isUpDirection = true;
            //Enter the searched number
            Console.Write("Enter searched number:");
            isCorrectEntry = int.TryParse(Console.ReadLine(), out searchedNumber);
            if (isCorrectEntry == false)
            {
                Console.WriteLine("Wrong entry!");
                return;
            }
            //Enter the elements of the array
            Console.WriteLine("Enter the elements of the array in ascending order separated by \",\":");
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
            
            int step = array.Length/2;
            int counter = 0;
            searchedIndex = 0;
            while (true)
            {
                if (isUpDirection)
	            {
		            searchedIndex = searchedIndex + step;
	            }
                else
                {
                    searchedIndex = searchedIndex - step;
                }

                if (searchedIndex < 0 || searchedIndex > array.Length-1)
                {
                    Console.WriteLine("The searched number {0} is not present in the array!", searchedNumber);
                    return;
                }
                
                if (array[searchedIndex] == searchedNumber)
                {
                    Console.WriteLine("The searched number has index:{0}",searchedIndex);
                    return;
                }
                else if(array[searchedIndex] > searchedNumber)
	            {
		            isUpDirection = false;
	            }
                else
                {
                    isUpDirection = true;
                }

                step = step/2;

                if (step < 1)
                {
                    step = 1;
                }
                if (searchedIndex < 0 || searchedIndex > array.Length)
                {
                    break;
                }

                counter++;

                if (counter > Math.Log(array.Length,2)+1)
                {
                    Console.WriteLine("The searched number {0} is not present in the array!", searchedNumber);
                    return;
                }
            }
        }
    }
}
