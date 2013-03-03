using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _7.Timer
{
    class Timer
    {
        //Delegate declaration
        private delegate void VoidExecutionDelegate();
        private delegate int IntExecutionDelegate(int number1, int number2);

        //Field of type ExecutionDelegate
        private VoidExecutionDelegate voidMethodsToExecute;
        private IntExecutionDelegate intMethodsToExecute;

        //Method that execute the Void methods delegate after certain time, certain number of times
        public void StartExecutionVoidMethods(uint secondsDelay, uint numberOfIterations)
        {
            //Convert seconds in 100ns units (ticks)
            long delayInTicks = secondsDelay * 10000000;

            Thread.Sleep(new TimeSpan(delayInTicks));
            for (int i = 0; i < numberOfIterations; i++)
            {
                voidMethodsToExecute();

                //Skip the delay at the last loop
                if (i != numberOfIterations - 1)
                {
                    Thread.Sleep(new TimeSpan(delayInTicks));
                }
            }
        }

        //Method that execute the Int methods delegate after certain time, certain number of times
        public void StartExecutionIntMethods(uint secondsDelay, uint numberOfIterations, int number1, int number2)
        {  
            //Convert seconds in 100ns units (ticks)
            long delayInTicks = secondsDelay * 10000000;
            Thread.Sleep(new TimeSpan(delayInTicks));
            for (int i = 0; i < numberOfIterations; i++)
            {
                intMethodsToExecute(number1, number2);
                
                //Skip the delay at the last loop
                if (i != numberOfIterations-1)
                {
                    Thread.Sleep(new TimeSpan(delayInTicks));
                }                
            }
        }

        //Method to add methods to voidMethodsToExecute delegate
        public void AddVoidMethodsToExecute(Action method)
        {
            voidMethodsToExecute += new VoidExecutionDelegate(method);
        }

        //Method to add methods to IntMethodsToExecute delegate
        public void AddIntMethodsToExecute(Func<int,int,int> method)
        {
            intMethodsToExecute += new IntExecutionDelegate(method);
        }
    }
}
