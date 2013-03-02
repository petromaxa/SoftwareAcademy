using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.StringBuilderSubstring
{
    class Tests
    {
        static void Main()
        {
            //Try the Substring method on class String
            string newString = "Pesho Plet Plete";
            Console.WriteLine("Try the Substring method on class String:");
            Console.WriteLine(newString.Substring(2));
            Console.WriteLine(newString.Substring(2, 2));

            //Try the Substring method on class StringBuilder
            Console.WriteLine("\nTry the Substring method on class StringBuilder:");
            StringBuilder newStringBuilder = new StringBuilder("Pesho Plet Plete");
            Console.WriteLine(newStringBuilder.Substring(2));
            Console.WriteLine(newStringBuilder.Substring(2, 2));
        }
    }
}
