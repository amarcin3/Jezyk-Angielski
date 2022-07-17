using System.Collections.Generic;

namespace JezykAngielski.Core.Models;

public class SampleOrder
{
    public long OrderID
    {
        get; set;
    }

    public string Company
    {
        get; set;
    }

    public string ShipTo
    {
        get; set;
    }

    public string Status
    {
        get; set;
    }

    public int SymbolCode
    {
        get; set;
    }

    public string SymbolName
    {
        get; set;
    }
    public char Symbol => (char)SymbolCode;
   
    // Tresc

    public string Note1
    {
        get; set;
    }
    public string DescNote1
    {
        get; set;
    }
    //------
    public string Note2
    {
        get; set;
    }
    public string DescNote2
    {
        get; set;
    }
    //------
    public string Note3
    {
        get; set;
    }
    public string DescNote3
    {
        get; set;
    }
}
