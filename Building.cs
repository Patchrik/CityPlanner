using System;
using System.Collections.Generic;

namespace Planner
{
  // Define class here
  public class Building
  {
    // private fields
    private string _designer { get; } = "Parker Kelley";
    private DateTime _dateConstructed { get; set; }
    private string _address { get; set; }
    private string _owner { get; set; }

    // Public Properties
    public int Stories { get; set; }
    public double Width { get; set; }
    public double Depth { get; set; }
    public double Volume
    {
      get
      {
        return Width * Depth * (3 * Stories);
      }
    }

    // Constructor for the Building class/Object
    public Building(string address)
    {
      if (address.Length > 5)
      {
        _address = address;
      }
    }

    // Construct method will set the private _dateConstructed field
    public void Construct()
    {
      _dateConstructed = DateTime.Now;
    }
    // Purchase method will set the private _owner string in the Building object
    public void Purchase(string buyerName)
    {
      _owner = buyerName;
    }

    // PrintDeed will write out the console 
    public void PrintDeed()
    {
      Console.WriteLine("");
      Console.WriteLine($"{_address}");
      Console.WriteLine("---------------");
      Console.WriteLine($"Designed by {_designer}");
      Console.WriteLine($"Constructed on {_dateConstructed}");
      Console.WriteLine($"Owned by {_owner}");
      Console.WriteLine($"{Volume} cubic meters of space");
    }

  }
}