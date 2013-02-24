using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ClassesTests
{
    static void Main()
    {
        //Create an array with five phones
        GSM[] phones = new GSM[5];

        Battery battery1 = new Battery("N10", 100, 30, BatteryType.NiMh);
        Display display1 = new Display(256, 30, 40);
        Battery battery2 = new Battery("L100", 200, 40, BatteryType.Li_Ion);
        Display display2 = new Display(1024, 50, 70);
        Battery battery3 = new Battery("L150", 250, 33, BatteryType.Li_Ion);
        Display display3 = new Display(64000, 50, 60);
        Battery battery4 = new Battery("L120", 180, 22, BatteryType.Li_Ion);
        Display display4 = new Display(256000, 30, 50);
        Battery battery5 = new Battery("N130", 190, 25, BatteryType.NiCd);
        Display display5 = new Display(2, 20, 20);
        phones[0] = new GSM("I1000","Siemens", 200, "Pesho",display1,battery1);
        phones[1] = new GSM("Galaxy", "Samsung", 1000, "Gosho", display2, battery2);
        phones[2] = new GSM("N72", "Nokia", 200, "Stancho", display3, battery3);
        phones[3] = new GSM("N9000", "Nokia", 50, "Pancho", display4, battery4);
        phones[4] = new GSM("IPhone3", "Apple", 300, "Stamat", display5, battery5);
        GSM.iPhone4S = "IPhone4S info";
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Phone {0}",i+1);
            Console.WriteLine("{0}\n",phones[i].ToString());
        }
            
        //Print the static field
        Console.WriteLine(GSM.iPhone4S);

        //Add three calls in the history of the first phone
        Call newCall1 = new Call(new DateTime(2013, 02, 23, 23, 10, 0),"+359885935333", 35);
        phones[0].AddCall(newCall1);
        Call newCall2 = new Call(new DateTime(2013, 05, 25, 12, 15, 0), "+359882352555", 55);
        phones[0].AddCall(newCall2);
        Call newCall3 = new Call(new DateTime(2012, 11, 15, 1, 10, 0), "+359885559666", 180);
        phones[0].AddCall(newCall3);

        //Calculate total price with price per minute = 0.37
        Console.WriteLine("\nTotal price of the calls = {0} lv",phones[0].CalculatePrice(0.37m));

        //Check and print the history
        for (int i = 0; i < phones[0].CallHistory.Count; i++)
        {
            Console.WriteLine("\nCall {0}", i + 1);
            Console.WriteLine("{0,-20}{1}","Date:",phones[0].CallHistory[i].DateAndTime.ToString("dd/MM/yyyy"));
            Console.WriteLine("{0,-20}{1}", "Time:", phones[0].CallHistory[i].DateAndTime.TimeOfDay);
            Console.WriteLine("{0,-20}{1}", "DialedPhoneNumber:", phones[0].CallHistory[i].DialedPhoneNumber);
            Console.WriteLine("{0,-20}{1}s", "Duration:", phones[0].CallHistory[i].Duration);
        }

        //Find the index of the longest call in the list
        int longestCallIndex = 0;
        uint longestDuration = 0;
        for (int i = 0; i < phones[0].CallHistory.Count; i++)
        {
            if (phones[0].CallHistory[i].Duration > longestDuration)
            {
                longestDuration = phones[0].CallHistory[i].Duration;
                longestCallIndex = i;
            }
        }

        //Remove the longest duration call from the history
        phones[0].RemoveCall(longestCallIndex);

        //Calculate total price with price per minute = 0.37 without the longest call
        Console.WriteLine("\nTotal price of the calls without the longest call = {0} lv\n", phones[0].CalculatePrice(0.37m));

        //Clear history
        phones[0].ClearHistory();
        Console.WriteLine("Call history list length after clear history = {0}\n", phones[0].CallHistory.Count); // Result is 0 => the list is empty
    }
}
