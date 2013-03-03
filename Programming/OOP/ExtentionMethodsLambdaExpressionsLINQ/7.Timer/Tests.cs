using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7.Timer
{
    class Tests
    {
        //Create two simple void methods
        public static void Method1()
        {
            Console.WriteLine("Execute Method 1!");
        }

        public static void Method2()
        {
            Console.WriteLine("Execute Method 2!");
        }


        //Create three simple int methods that takes two int arguments
        public static int Method3Subtract(int number1, int number2)
        {
            Console.WriteLine("Execute Method 3!");
            Console.WriteLine("The sum = {0}", number1 + number2);
            return number1 + number2;
        }

        public static int Method4Add(int number1, int number2)
        {
            Console.WriteLine("Execute Method 4!");
            Console.WriteLine("The substraction result = {0}", number1 - number2);
            return number1 - number2;
        }

        public static int Method5Product(int number1, int number2)
        {
            Console.WriteLine("Execute Method 5!");
            Console.WriteLine("The product = {0}", number1 * number2);
            return number1 * number2;
        }


        static void Main()
        {

            Timer newTimer = new Timer();
            
            //Add methods to the Void Methods delegate
            newTimer.AddVoidMethodsToExecute(Method1);
            newTimer.AddVoidMethodsToExecute(Method2);

            //Execute the methods in the Void Methods delegates 3 times with 1s delay
            newTimer.StartExecutionVoidMethods(1, 3);


            //Add methods to the Int Methods delegate
            newTimer.AddIntMethodsToExecute(Method3Subtract);
            newTimer.AddIntMethodsToExecute(Method4Add);
            newTimer.AddIntMethodsToExecute(Method5Product);

            //Execute the methods in the Int Methods delegates 2 times with 2s delay
            newTimer.StartExecutionIntMethods(2, 2, 100, 50);
        }
    }
}
