using System.Collections.Generic;
using Boulangerie.Models;

namespace Boulangerie.Models
{
  public class Item
  {
    public int Quantity { get; set; } = 0;
    public int Price { get; set; }
    public int TotalPrice { get; set; } = 0;

    public void AddItems(int numberOfItems)
    {
      Quantity += numberOfItems;
    }

    // public void GrandTotal(int gTotal)
    // {
    //   GTotal = Pastry.TotalPrice += Bread.TotalPrice;
    // }
   
  }
}