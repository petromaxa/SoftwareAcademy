using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _17.SubsetSumOfKElements
{
    class SubsetSumOfKElements
    {
        static void Main()
        {
            bool isCorrectEntry = true;
            int N = 0;
            int K = 0;
            int S = 0;

            Console.Write("Enter the size of the array N:");
            isCorrectEntry = int.TryParse(Console.ReadLine(), out N);
            if (isCorrectEntry == false || (isCorrectEntry && N <= 0))
            {
                Console.WriteLine("Wrong entry!");
                return;
            }
            
            Console.Write("Enter the number of the elements in the subset K:");
            isCorrectEntry = int.TryParse(Console.ReadLine(), out K);
            if (isCorrectEntry == false || (isCorrectEntry && K <= 0) || (isCorrectEntry && K > N))
            {
                Console.WriteLine("Wrong entry!");
                return;
            }
            

            Console.Write("Enter the searched sum S:");
            isCorrectEntry = int.TryParse(Console.ReadLine(), out S);
            if (isCorrectEntry == false)
            {
                Console.WriteLine("Wrong entry!");
                return;
            }

            
            int[] array = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write("Enter the {0}-th element of the array:",i);
                isCorrectEntry = int.TryParse(Console.ReadLine(), out array[i]);
                if (isCorrectEntry == false)
                {
                    Console.WriteLine("Wrong entry!");
                    return;
                }
            }
            
            int checkSum = 0;
            int elementsCounter = 0;
            int numberOfSubsets = (int)Math.Pow(2, N);
            for (int i = 1; i < numberOfSubsets; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    int mask = 1 << j;
                    int iAndMask = i & mask;
                    int firstBit = iAndMask >> j;
                    if (firstBit == 1)
                    {
                        checkSum = checkSum + array[j];
                        elementsCounter++;
                    }
                }
                if (checkSum == S && elementsCounter == K)
                {
                    Console.WriteLine("There is a subset of {0} elements with sum = {1}", K, S);
                    return;
                }
                checkSum = 0;
                elementsCounter = 0;
            }
            Console.WriteLine("There is no subset of {0} elements with sum = {1}", K, S);
        }
    }
}
