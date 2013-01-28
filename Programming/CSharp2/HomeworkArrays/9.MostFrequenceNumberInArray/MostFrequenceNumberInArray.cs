using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9.MostFrequenceNumberInArray
{
    class MostFrequenceNumberInArray
    {
        static void Main()
        {
            bool isCorrectEntry = true;
            int mostFreqElementContainer;
            int mostFrequentElement;
            int freqCounter;
            int numberOfMostFreqElements;
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
            Array.Sort(array);
            mostFreqElementContainer = array[0];
            mostFrequentElement = array[0];
            numberOfMostFreqElements = 1;
            freqCounter = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (mostFreqElementContainer == array[i])
                {
                    freqCounter++;
                    if (freqCounter > numberOfMostFreqElements)
                    {
                        numberOfMostFreqElements = freqCounter;
                        mostFrequentElement = array[i];
                    }
                }
                else
                {
                    mostFreqElementContainer = array[i];
                    freqCounter = 1;
                }
            }
            Console.WriteLine("The most frequent element is :{0}",mostFrequentElement);
            Console.WriteLine("Number of times pressent in array:{0}",numberOfMostFreqElements);

        }
    }
}
