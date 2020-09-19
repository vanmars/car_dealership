using System;
using System.Collections.Generic;
using Dealership.Models;

namespace Dealership
{
  public class Program
  {
    public static void Main()
    {
      // Create new instances of class Car
      Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792);
      Car yugo = new Car("1980 Yugo Koral", 700, 56000);
      Car ford = new Car("1988 Ford Country Squire", 1400, 239001);
      Car amc = new Car("1976 AMC Pacer", 400, 198000);

      // Add List to store all new Car instances
      List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

      // Invoke Setter Method, just for practice
      yugo.SetPrice(300);

      // User Input
      Console.WriteLine(Car.MakeSound("bang"));
      Console.WriteLine(Car.MakeSmell("sour milk"));
      Console.WriteLine("Enter maximum price: ");
      string stringMaxPrice = Console.ReadLine();
      int maxPrice = int.Parse(stringMaxPrice);

      // Create new List to store values matching user input parameters
      List<Car> CarsMatchingSearch = new List<Car>(0);

      // Use foreach loop to push values to CarsMatchingSearch List
      foreach (Car automobile in Cars)
      {
        if (automobile.WorthBuying(maxPrice))
        {
          CarsMatchingSearch.Add(automobile);
        }
      }

      // Use foreach loop to console write details of each car in the CarsMatchingSearch List
      foreach(Car automobile in CarsMatchingSearch)
      {
        Console.WriteLine("----------------------");
        Console.WriteLine(automobile.GetMakeModel());
        Console.WriteLine(automobile.GetMiles() + " miles");
        Console.WriteLine("$" + automobile.GetPrice());
      }
    }
  }
}