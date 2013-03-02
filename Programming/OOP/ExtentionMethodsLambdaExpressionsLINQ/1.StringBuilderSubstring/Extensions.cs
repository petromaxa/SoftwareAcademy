using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.StringBuilderSubstring
{
    public static class Extensions
    {
        public static string Substring(this StringBuilder str, int startIndex, int length)
        {
            if (startIndex < 0 || startIndex > str.Length-1)
            {
                throw new ArgumentException("The substring start index is out of range of the string!");
            }
            if (length < 0 || length > str.Length - startIndex)
            {
                throw new ArgumentException("The specified substring length is invalid!");
            }
            char[] newCharArray = new char[length];
            str.CopyTo(startIndex,newCharArray, 0, length);
            return new string (newCharArray);
        }

        public static string Substring(this StringBuilder str, int startIndex)
        {
            if (startIndex < 0 || startIndex > str.Length - 1)
            {
                throw new ArgumentException("The substring start index is out of range of the string!");
            }
            char[] newCharArray = new char[str.Length - startIndex];
            str.CopyTo(startIndex, newCharArray, 0, str.Length - startIndex);
            return new string(newCharArray);
        }
    }
}
