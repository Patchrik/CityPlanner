using System;
using System.Collections.Generic;

namespace Planner
{
  class Program
  {
    static void Main(string[] args)
    {
      Building Overton = new Building("4960 Overton Brentwood");

      Building EightSixFive = new Building("865 Bellvue Rd");

      Building SpoopVille = new Building("666 Tragic Way");

      City Simsville = new City("Simsville", "Bobby Robertson", "2077");

      Overton.Width = 1000;
      Overton.Depth = 650;
      Overton.Stories = 2;

      Overton.Construct();

      Overton.Purchase("Doug Dimmadome");



      EightSixFive.Width = 2500;
      EightSixFive.Depth = 1000;
      EightSixFive.Stories = 2;

      EightSixFive.Construct();

      EightSixFive.Purchase("Social Leech");

      SpoopVille.Width = 5000;
      SpoopVille.Depth = 666.13;
      SpoopVille.Stories = 13;

      SpoopVille.Construct();

      SpoopVille.Purchase("Lucifer Def-Not Thatwon");


      Console.WriteLine("Hello City Planner!");
      Console.WriteLine("-------------------");

      Overton.PrintDeed();

      EightSixFive.PrintDeed();

      SpoopVille.PrintDeed();

      Simsville.PrintCityDeets();

      Simsville.PrintBuildingList();

      Simsville.AddToBuildingList(Overton);

      Simsville.AddToBuildingList(EightSixFive);

      Simsville.AddToBuildingList(SpoopVille);

      Simsville.PrintBuildingList();

    }
  }
}
