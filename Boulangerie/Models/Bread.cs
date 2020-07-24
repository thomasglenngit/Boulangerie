using System.Collections.Generic;
using System;
using Boulangerie.Models;

namespace Boulangerie.Models
{
  public class Bread
  {

    public int Price { get; set; }
    private static List<Bread> _instances = new List<Bread> {};

    public int Id { get; }

    public Bread(int price)
    {
      Price = 5;
      _instances.Add(this);
      Id = _instances.Count;
    }
     public static List<Thing> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Price(int breadsPrice)
    {
      breadsPrice = 0;
      foreach(Bread Price in _instances )
      {
        breadsPrice += Price;

        if(_instances >= 2)
        {
          breadsPrice -= 5;
        }
      }
      return breadsPrice;

    }
    
  }
}