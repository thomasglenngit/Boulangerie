using System.Collections.Generic;
using System;
using Boulangerie.Models;

namespace Boulangerie.Models
{
  public class Pastry : Item
  {
    
    public Pastry()
    {
      Price = 2;
      TotalPrice = 0;
    }

    public void CalculatePrice()
    {
      foreach(Pastry pastry in _instances )
      {
        TotalPrice = pastry * Price;

        if(_instances % 3 == 0)
        {
          TotalPrice *= 0.83;
        }
      }

    }
    
  }

}
  