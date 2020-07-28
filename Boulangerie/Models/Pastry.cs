using System;
using System.Collections.Generic;
using Boulangerie.Models;

namespace Boulangerie.Models
{
  public class Pastry : Item
  {
  
    public Pastry()
    {
      Price = 2; 
      
    }

    public void CalculateOrder()
    {
      TotalPrice = Price * Quantity;
      if (Quantity % 3 == 0)
      {
        TotalPrice -= 1;
      }
    }
  }
}