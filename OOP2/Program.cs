using System;
using System.Collections.Generic;
using System.Linq;

public class TV
{
    private bool bIsTVOn = false;
    private int TVChannel = 0;

    public void ChangeStatus()
    {
        bIsTVOn = !bIsTVOn;
    }

    public void ChangeChannel(int InChannel)
    {
        TVChannel = InChannel;
    }

    public void PrintInfo()
    {
        Console.WriteLine((bIsTVOn ? "TV is On\nChannel: " + TVChannel : "TV is Off") + "\n");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        TV tv = new TV();
        tv.PrintInfo();
        tv.ChangeStatus();
        tv.PrintInfo();
        tv.ChangeChannel(3);
        tv.PrintInfo();
    }
}