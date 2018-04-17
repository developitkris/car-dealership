using System.Collections.Generic;
using System;

namespace Dealership.Models
{

  public class Car
  {
    private string _brand;
    private string _model;
    private int _mileage;
    private int _price;
    private static List<Car> _instances = new List<Car> {};


    public Car(string carBrand, string carModel, int carMileage, int carPrice)
    {
      _brand = carBrand;
      _model = carModel;
      _mileage = carMileage;
      _price = carPrice;
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }
      public void Save()
    {
      _instances.Add(this);
    }

    public void SetBrand(string newBrand)
    {
      _brand = newBrand;
    }
    public string GetBrand()
    {
      return _brand;
    }

    public void SetModel(string newModel)
    {
      _model = newModel;
    }
    public string GetModel()
    {
      return _model;
    }

    public void SetMileage(int newMileage)
    {
      if (newMileage >= 0){
        _mileage = newMileage;
      }
      else {
        Console.WriteLine("The mileage for this car is not valid");
      }
    }
    public int GetMileage()
    {
      return _mileage;
    }

    public void SetPrice(int newPrice)
    {
      if (newPrice >= 0 ) {
        _price = newPrice;
      }
      else {
        Console.WriteLine("The price for this car is not valid");
      }
    }
    public int GetPrice()
    {
      return _price;
    }
  }
}
