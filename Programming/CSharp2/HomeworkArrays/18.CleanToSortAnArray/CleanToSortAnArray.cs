using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _18.CleanToSortAnArray
{
    class CleanToSortAnArray
    {
        static void Main()
        {
            bool isCorrectEntry = true;
            Console.WriteLine("Enter the elements of the array separated by \",\":");
            string[] stringArray = Console.ReadLine().Split(',');
            List<int> numbers = new List<int>();
            List<int> tempNumbers = new List<int>();
            int newNumber = 0;
            int sortChecker = 0;
            for (int i = 0; i < stringArray.Length; i++)
            {
                isCorrectEntry = int.TryParse(stringArray[i], out newNumber);

                if (isCorrectEntry == false)
                {
                    Console.WriteLine("Wrong entry!");
                    return;
                }
                else
                {
                    numbers.Add(newNumber);
                    tempNumbers.Add(newNumber);
                    if(i > 0 && numbers[i-1] <= numbers[i])
                    {
                        sortChecker++;
                    }
                }
            }

            if (sortChecker == numbers.Count-1)
	        {
		        Console.WriteLine("The array is aready sorted!");
                return;
	        }

            if (numbers.Count == 2 && numbers[0] > numbers[1])
            {
                Console.WriteLine("The sorted array is:");
                Console.WriteLine("{0}",numbers[0]);
                return;
            }

            bool[] array = new bool[numbers.Count];
            int numberOfSubsets = (int)Math.Pow(2,numbers.Count);
            int previuosMaxLength = 1;
            int maxLength = 1;
            int previousElementsPosition = 1;
            int elementsPosition = 0;
            int lengthSequenceCounter = 1;
            int counter = 0;

            //Check all the possibilities
            for (int i = 1; i < numberOfSubsets; i++)
            {
                for (int j = 0; j < numbers.Count; j++)
                {
                    int mask = 1 << j;
                    int iAndMask = i & mask;
                    int firstBit = iAndMask >> j;
                    if (firstBit == 1)
                    {
                        tempNumbers.RemoveAt(j - counter);
                        counter++;
                    }
                }
                counter = 0;
                previousElementsPosition = elementsPosition;
                previuosMaxLength = maxLength;

                //Check if the subset is in increasing order
                for (int j = 1; j < tempNumbers.Count; j++)
                {
                    if (tempNumbers[j - 1] <= tempNumbers[j])
                    {
                        lengthSequenceCounter++;
                        if (lengthSequenceCounter > maxLength)
                        {
                            maxLength = lengthSequenceCounter;
                            elementsPosition = i;
                        }
                    }
                    else
                    {
                        maxLength = previuosMaxLength;
                        elementsPosition = previousElementsPosition;
                        break;
                    }
                }
                lengthSequenceCounter = 1;

                //restore tempNumbers List
                for (int j = 0; tempNumbers.Count < numbers.Count; j++)
                {
                    tempNumbers.Add(0);
                }

                for (int j = 0; j < numbers.Count; j++)
                {
                    tempNumbers[j] = numbers[j];
                }

            }

            counter = 0;
            int printCounter = 1;

            //Print the new sequence
            Console.WriteLine("The sorted array is:");
            for (int j = 0; j < numbers.Count; j++)
            {
                int mask = 1 << j;
                int iAndMask = elementsPosition & mask;
                int firstBit = iAndMask >> j;
                if (firstBit == 1)
                {
                    tempNumbers.RemoveAt(j - counter);
                    counter++;
                }
                else
                {
                    if (printCounter < maxLength)
                    {
                        Console.Write("{0},", tempNumbers[j - counter]);
                        printCounter++;
                    }
                    else
                    {
                        Console.Write("{0}", tempNumbers[j - counter]);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
