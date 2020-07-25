using System;
using Boulangerie.Models;
using System.Collections.Generic;

namespace Boulangerie
{

  public class Program
  {

    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Boulangerie!");
      Console.WriteLine("We have two items for sale,");
      Console.WriteLine("Bread or Pastries");
      Console.WriteLine("Bread is $5 for a loaf; buy two, get one free.");
      Console.WriteLine("Pastries are $2 each, or 3 for $5.");
      Console.WriteLine("Would you like some bread? (yes or no)");
        string breadBuy = Console.ReadLine().ToLower();
      if (breadBuy == "yes")
      {
        Console.WriteLine("How many loaves of bread can I get for you today?");
        string breadOrder = Console.ReadLine().ToLower();
        Bread newBread = new Bread();
        newBread.AddItems(int.Parse(breadOrder));
        newBread.CalculateOrder();
        Console.WriteLine("Your bread order comes to: $" + newBread.TotalPrice);

        Console.WriteLine("Would you like some pastries? (yes or no)");
          string pastryBuy = Console.ReadLine().ToLower();
        if (pastryBuy == "yes")
        {
        
        Console.WriteLine("How many cupcakes would you like?");
        string pastryOrder = Console.ReadLine().ToLower();
        Pastry newPastry = new Pastry();
        newPastry.AddItems(int.Parse(pastryOrder));
        newPastry.CalculateOrder();
        Console.WriteLine("Your pastry order comes to: $" + newPastry.TotalPrice);
        Console.WriteLine("Would you care for anything else (yes or no)");
        string finalAnswer = Console.ReadLine().ToLower();
          if (finalAnswer == "yes")
          {
            Main();
          }
          else
          {
        int grandTotal = newPastry.TotalPrice + newBread.TotalPrice;
        Console.WriteLine("Thanks, for coming in today.");
        Console.WriteLine("Your grand total comes to: $" + grandTotal);
          }

        }
      } 
      else
      {
        Console.WriteLine("Thanks for coming to smell the fresh-baked bread. Have a nice day.");
      }
    } 
  }
}
