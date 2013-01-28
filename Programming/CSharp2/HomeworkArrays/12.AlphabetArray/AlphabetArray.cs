using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12.AlphabetArray
{
    class AlphabetArray
    {
        static void Main()
        {
            char[] alphabetArray = new char[26];
            int index = 0;
            for (int i = 65; i < 91; i++, index++)
            {
                alphabetArray[index] = Convert.ToChar(i);
            }
            Console.WriteLine("Enter a word with capital letters:");
            string word = Console.ReadLine();
            Console.WriteLine("The letters in the word have index:");
            for (int i = 0; i < word.Length-1; i++)
            {
                Console.Write("[{0}],",word[i]-65);    
            }
            Console.WriteLine("[{0}]", word[word.Length-1] - 65);  

        }
    }
}
