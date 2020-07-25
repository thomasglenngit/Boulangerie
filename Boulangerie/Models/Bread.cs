using System;
using System.Collections.Generic;
using Boulangerie.Models;

namespace Boulangerie.Models
{
  public class Bread : Item
  {

    public Bread()
    {
      Price = 5; 
    }

    public void CalculateOrder()
    {
      TotalPrice = Price * Quantity;
      if (Quantity >= 3)
      {
        TotalPrice -= 5;
      }
    }
  }
}