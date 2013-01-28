using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.TwoArraysComparison
{
    class TwoArraysComparison
    {
        static void Main()
        {
            int[] array1 = new int[5];
            int[] array2 = new int[5];
            bool isCorrectEntry = true;
            bool isDiferenceFound = false;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter the {0} element of the first array:",i);
                isCorrectEntry = int.TryParse(Console.ReadLine(),out array1[i]);
                if (isCorrectEntry == false)
                {
                    Console.WriteLine("Wrong entry!");
                    return;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter the {0} element of the second array:", i);
                isCorrectEntry = int.TryParse(Console.ReadLine(), out array2[i]);
                if (isCorrectEntry == false)
                {
                    Console.WriteLine("Wrong entry!");
                    return;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                if (array1[i]!=array2[i])
                {
                    Console.WriteLine("Element {0} is different!",i);
                    isDiferenceFound = true;
                }
            }

            if (isDiferenceFound == false)
            {
                Console.WriteLine("Both arrays are equal!");
            }
        }
    }
}
