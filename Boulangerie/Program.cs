using System;
using Boulangerie.Models;
using System.Collections.Generic;

namespace Boulangerie
{

  public class Program
  {

    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Boulangerie! We have two items for sale. Bread or Pastries.");
      Console.WriteLine("Bread is $5 for a loaf; buy two, get one free. Quantity 3.");
      Console.WriteLine("Pastries are $2 each, or 3 for $5. Quantity, 3.");
      Console.WriteLine("Would you like to order something? (yes or no)");
        string input = Console.ReadLine();

      if (input == "yes")
      {
        AddBread(input);
      } 
      else
      {
        Console.WriteLine("Thanks for stopping by.");
      }
    }

    public static void AddBread(string input)
    {
      Console.WriteLine("How many loaves of bread can I get for you today?");
      string order = Console.ReadLine().ToLower();
      // Bread theBread = new Bread();
      // theBread.GetAll();
      // theBread.Price();
      // Console.WriteLine(theBread.Price);
      Console.WriteLine("Here is your total. Would you care for any more? (yes or no");
      string answer = Console.ReadLine().ToLower();
      if (answer == "yes")
      {
        Main();
      }
    }
      
  }
}
