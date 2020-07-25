using System.Collections.Generic;
using System;
using Boulangerie.Models;

namespace Boulangerie.Models
{
  public class Bread : Item
  {

    public Bread()
    {
      Price = 5;
      TotalPrice = 0;
    }
    
    public void CalculatePrice()
    {
      foreach(Bread bread in _instances )
      {
        TotalPrice = bread * Price;
      }
        if(_instances >= 2)
        {
          TotalPrice -= 5;
        }
    }
    
  }
}