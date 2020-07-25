using System;

namespace Boulangerie.Models
{
  public class Bread
  {
    public int Price { get; set; }

    public Bread(int price)
    {
      Price = price; 
    }
  }
}