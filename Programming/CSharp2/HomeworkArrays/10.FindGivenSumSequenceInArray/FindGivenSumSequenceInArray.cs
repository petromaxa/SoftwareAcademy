using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10.FindGivenSumSequenceInArray
{
    class FindGivenSumSequenceInArray
    {
        static void Main()
        {
            bool isCorrectEntry = true;
            int S = 0;
            int sum=0;
            Console.Write("Enter searched sum:");
            isCorrectEntry = int.TryParse(Console.ReadLine(), out S);
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
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    sum = sum + array[j];
                    if (sum==S)
                    {
                        Console.Write("There is a subsequence of {0} elements: ", j+1-i);
                        for (int k = i; k < j; k++)
                        {
                            Console.Write("{0},", array[k]);
                        }
                        Console.Write("{0} ", array[j]);
                        Console.Write("with sum ={0}\n", S);
                        return;
                    }
                }
                sum = 0;
            }
            Console.WriteLine("There is no subsequence with sum={0}",S);
        }
    }
}
