using System;
using System.Collections.Generic;

namespace Planner
{
  public class City
  {
    // These will be the varables that a city has -
    private string _cityName { get; set; }
    private string _mayorName { get; set; }
    private string _yearEstablished { get; set; }

    public List<Building> buildingList { get; set; }

    // Here is the city constructor
    public City(string City, string Mayor, string Year)
    {
      // Assign the values at decleration
      _cityName = City;
      _mayorName = Mayor;
      _yearEstablished = Year;
      buildingList = new List<Building>();

    }

    // This is a method to add a Building Object to a List within a City Object.
    public void AddToBuildingList(Building building)
    {
      buildingList.Add(building);
    }
    // This method will check to see if there's anything in the building list
    // if the building list is empty let the user know.
    public void PrintBuildingList()
    {
      if (buildingList.Count > 0)
      {
        foreach (Building building in buildingList)
        {
          Console.WriteLine("");
          Console.WriteLine($"Here's a list of buildings in {_cityName} right now!");
          building.PrintDeed();
        }
      }
      else
      {
        Console.WriteLine($"Seems like there are no buildings in {_cityName} right now? Did you add any?");
      }
    }
    // This will print out a city's details
    public void PrintCityDeets()
    {
      Console.WriteLine("");
      Console.WriteLine($"{_cityName}");
      Console.WriteLine("---------------");
      Console.WriteLine($"The Mayor is {_mayorName}");
      Console.WriteLine($"Founded on {_yearEstablished}");
    }

  }
}