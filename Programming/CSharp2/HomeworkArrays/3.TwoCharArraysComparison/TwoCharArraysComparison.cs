using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.TwoCharArraysComparison
{
    class TwoCharArraysComparison
    {
        static void Main()
        {
            string firstCharArray = null;
            string secondCharArray = null;
            bool isFirstBigger = true;
            bool isLengthEqual = true;
            bool isFirstFirst = false;
            bool isDifferenceFound = false;
            Console.WriteLine("Enter a string for the first char array:");
            firstCharArray = Console.ReadLine();
            Console.WriteLine("Enter a string for the second char array:");
            secondCharArray = Console.ReadLine();
            if (firstCharArray.Length > secondCharArray.Length)
	        {
		        isFirstBigger = true;
                isLengthEqual = false;
	        }

            if (firstCharArray.Length < secondCharArray.Length)
            {
                isFirstBigger=false;
                isLengthEqual=false;
            }


            for (int i = 0; i < Math.Min(firstCharArray.Length,secondCharArray.Length); i++)
            {
                if (firstCharArray[i] > secondCharArray[i])
                {
                    isFirstFirst = true;
                    isDifferenceFound = true;
                    break;
                    
                }

                if (firstCharArray[i] < secondCharArray[i])
                {
                    isFirstFirst = false;
                    isDifferenceFound = true;
                    break;
                }
            }

            if ((isDifferenceFound && isFirstFirst) || (isDifferenceFound == false && isLengthEqual == false && isFirstBigger==false))
            {
                Console.WriteLine("First array is lexicographically before the second one!");
            }
            else if (isDifferenceFound == false && isLengthEqual)
            {
                Console.WriteLine("Both arrays are equal!");
            }
            else
            {
                Console.WriteLine("Second array is lexicographically before the first one!");
            }
        }
    }
}
