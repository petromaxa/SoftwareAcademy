using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _16.SubsetSum
{
    class SubsetSum
    {
        static void Main()
        {
            bool isCorrectEntry = true;
            int elementsEqualToS = 0;
            int numberOfGoodSubsets = 0;
            long S = 0;
            Console.Write("Enter the searched sum:");
            isCorrectEntry = long.TryParse(Console.ReadLine(),out S);
            if (isCorrectEntry == false)
            {
                Console.WriteLine("Wrong entry!");
                return;
            }
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
                if (array[i] == S)
                {
                    elementsEqualToS++;
                }
            }
            numberOfGoodSubsets = elementsEqualToS + FindSubsetSum(array, S);
            if (numberOfGoodSubsets == 0)
            {
                Console.WriteLine("There is no subsets with sum = {0}", S);
            }
            else
            {
                Console.WriteLine("There is {0} subsets with sum = {1}", numberOfGoodSubsets,S);  
            }
                    
        }


        private static int FindSubsetSum(int[] numbers, long S)
        {
            int numberOfSubsets = 0;
            int allSubsets = (int)Math.Pow(2, numbers.Length);
            long[] dynamicSums = new long[allSubsets];
            for (int i = 1; i < numbers.Length; i++)// numbers in the array
            {
                int j, k;
                for (j = 0; j < ((1 << i) - (i + 1)); j++)// the sum with already summed elements
                {

                    if ((dynamicSums[(1 << i) - (i + 1) + j] = numbers[i] + dynamicSums[j]) == S)
                    {
                        numberOfSubsets++;
                    }
                }
                for (k = 0; k < i; k++)// the sums with the new elements
                {
                    if ((dynamicSums[(1 << i) - (i + 1) + (j + k)] = numbers[k] + numbers[i]) == S)
                    {
                        numberOfSubsets++;
                    }
                }
            }
            return numberOfSubsets;
        }           
    }
}
