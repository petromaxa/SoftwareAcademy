using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Call
{
    //Readonly fields, because once set they don't need to be changed
    public readonly DateTime dateAndTime;
    public readonly string dialedPhoneNumber;
    public readonly uint duration;

    //Constructor
    public Call(DateTime dateAndTime, string dialedPhoneNumber, uint duration)
    {
        this.duration = duration;
        this.dateAndTime = dateAndTime;
        this.dialedPhoneNumber = dialedPhoneNumber;
    }

    //Properties
    public DateTime DateAndTime
    {
        get
        {
            return this.dateAndTime;
        }
    }
    public uint Duration
    {
        get
        {
            return this.duration;
        }
    }
    public string DialedPhoneNumber
    {
        get
        {
            return this.dialedPhoneNumber;
        }
    }
}
