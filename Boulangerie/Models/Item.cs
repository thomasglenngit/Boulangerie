using System.Collections.Generic;

namespace Boulangerie.Models
{
  public class Item
  {
    public int Price { get; set; }

    public int TotalPrice { get; set; }

    public int Id { get; }

    private static List<Item> _instances = new List<Item> {};

    public Item(int price, int totalPrice)
    {
      Price = price;
      TotalPrice = totalPrice;
      _instances.Add(this);
      Id = _instances.Count;
    }

    // public void AddItems()
    // {
    //   _instances.Add(this);
    //   Id = _instances.Count;
    // }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
    
  }
}