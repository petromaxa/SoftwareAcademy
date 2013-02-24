using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class GSM
{
    //Fields
    private string model;
    private string manifacturer;
    private decimal price;
    private string owner;
    private Display display;
    private Battery battery;
    public static string iPhone4S { get; set; }
    private List<Call> callHistory = new List<Call>();

    //Constructors
    public GSM(string model, string manifacturer) 
        : this(model, manifacturer, 0)
    {
    }
    public GSM(string model, string manifacturer, decimal price)
        : this(model, manifacturer, price, null)
    {
    }
    public GSM(string model, string manifacturer, decimal price, string owner)
        : this(model, manifacturer, price, owner, new Display(0, 0, 0))
    {
    }
    public GSM(string model, string manifacturer, decimal price, string owner, Display display)
        : this(model, manifacturer, price, owner, display, new Battery(null, 0, 0))
    {
    }
    public GSM(string model, string manifacturer, decimal price, string owner, Display display, Battery battery)
    {
        this.model = model;
        this.manifacturer = manifacturer;
        this.price = price;
        this.owner = owner;
        this.battery = battery;
        this.display = display;
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
    public string Manifacturer
    {
        get
        {
            return this.manifacturer;
        }
        set
        {
            if (value != null && value.Length >= 2)
            {
                this.manifacturer = value;
            }
            else
            {
                throw new ArgumentException("The manifacturer name cannot be null and it must contain at least 2 characters!");
            }
        }
    }
    public decimal Price
    {
        get
        {
            return this.price;
        }
        set
        {
            this.price = value;
        }
    }
    public string Owner
    {
        get
        {
            return this.owner;
        }
        set
        {
            if (value != null && value.Length >= 2)
            {
                this.owner = value;
            }
            else
            {
                throw new ArgumentException("The owner name cannot be null and it must contain at least 2 characters!");
            }
        }
    }

    public Display Display
    {
        get
        {
            return this.display;
        }
        set
        {
            this.display = value;
        }
    }
    public Battery Battery
    {
        get
        {
            return this.battery;
        }
        set
        {
            this.battery = value;
        }
    }

    public List<Call> CallHistory
    {
        get
        {
            return this.callHistory;
        }
    }

    //Methods
    //Override ToString
    public override string ToString()
    {
        //Add all GSM fields info
        string GSMinfo = String.Format("{0,-15}{1,-15}\r\n{2,-15}{3,-15}\r\n{4,-15}{5} leva\r\n{6,-15}{7,-15}", 
            "Model:", model,"Manifacturer:",manifacturer,"Price:", price,"Owner:",owner);
        //Add Display info and Battery info
        GSMinfo = String.Format("{0}\r\n{1,-15}{2} colors, {3}x{4}mm\r\n{5,-15}{6}, {7}, Idle time: {8}h, Talk time: {9}h", GSMinfo, 
            "Display:", display.NumberOfColors, display.Width, display.Height,
            "Battery:", battery.Model, battery.Type, battery.HoursIdle, battery.HoursTalk);
        return GSMinfo;
    }

    //Add call in the history
    public void AddCall(Call newCall)
    {
        this.callHistory.Add(newCall);
    }
    //Remove call from the history
    public void RemoveCall(int position)
    {
        if (position < 0 || position > this.callHistory.Count-1)
        {
            throw new ArgumentException("The target position for removing an element is out of the list positions!");
        }
        else
        {
            this.callHistory.RemoveAt(position);
        }
    }
    //Clear history
    public void ClearHistory()
    {
        this.callHistory.Clear();
    }

    //Calculate price
    public decimal CalculatePrice(decimal pricePerMinute)
    {
        decimal totalPrice = 0;
        long totalTime = 0;
        for (int i = 0; i < this.callHistory.Count; i++)
        {
            totalTime = totalTime + callHistory[i].Duration;
        }
        totalPrice = totalTime * pricePerMinute;
        return totalPrice;
    }
}
