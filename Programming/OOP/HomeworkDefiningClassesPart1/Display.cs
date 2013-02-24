using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Display
{
    //Fields
    private uint numberOfColors;
    private uint height;
    private uint width;

    //Constructors
    public Display()
        : this(0)
    {
    }
    public Display(uint numberOfColors)
        : this(numberOfColors, 0, 0)
    {
    }
    public Display(uint numberOfColors, uint width, uint height)
    {
        this.numberOfColors = numberOfColors;
        this.width = width;
        this.height = height;
    }

    // Properties
    public uint NumberOfColors
    {
        get
        {
            return this.numberOfColors;
        }
        set
        {
            this.numberOfColors = value;
        }
    }
    public uint Width
    {
        get
        {
            return this.width;
        }
        set
        {
            this.width = value;
        }
    }
    public uint Height
    {
        get
        {
            return this.height;
        }
        set
        {
            this.height = value;
        }
    }
}