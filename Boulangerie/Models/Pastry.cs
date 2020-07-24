using System.Collections.Generic;
using System;
using Boulangerie.Models;

namespace Boulangerie.Models
{
  public class Pastry
  {

    public int Price { get; set; }
    private static List<Pastry> _instances = new List<Pastry> {};

    public int Id { get; }

    public Pastry(int price)
    {
      Price = 5;
      _instances.Add(this);
      Id = _instances.Count;
    }
     public static List<Pastry> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Price(int pastriesPrice)
    {
      pastriesPrice = 0;
      foreach(Pastry Price in _instances )
      {
        pastriesPrice += Price;

        if(_instances >= 2)
        {
          pastriesPrice -= 5;
        }
      }
      return pastriesPrice;

    }
    
  }

}
  