using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public enum BatteryType
{
    Unknown, Li_Ion, NiMh, NiCd, Silver_Oxide
}

public class Battery
{
    //Fields
    private string model;
    private uint hoursIdle;
    private uint hoursTalk;
    private BatteryType type;

    //Constructors
    public Battery(string model)
        : this(model, 0)
    {
    }
    public Battery(string model, uint hoursIdle)
        : this(model, hoursIdle, 0)
    {
    }
    public Battery(string model, uint hoursIdle, uint hoursTalk)
        : this(model, hoursIdle, hoursTalk, BatteryType.Unknown)
    {
    }
    public Battery(string model, uint hoursIdle, uint hoursTalk, BatteryType type)
    {
        this.model = model;
        this.hoursIdle = hoursIdle;
        this.hoursTalk = hoursTalk;
        this.type = type;
    }

    //Properties
    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            if (value != null && value.Length >= 2)
            {
                this.model = value;
            }
            else
            {
                throw new ArgumentException("The model name cannot be null and it must contain at least 2 characters!");
            }
        }
    }
    public uint HoursIdle
    {
        get
        {
            return this.hoursIdle;
        }
        set
        {
            this.hoursIdle = value;
        }
    }
    public uint HoursTalk
    {
        get
        {
            return this.hoursTalk;
        }
        set
        {
            this.hoursTalk = value;
        }
    }
    public BatteryType Type
    {
        get
        {
            return this.type;
        }
        set
        {
            this.type = value;
        }
    }
}
