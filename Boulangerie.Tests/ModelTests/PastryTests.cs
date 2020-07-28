using Microsoft.VisualStudio.TestTools.UnitTesting;
using Boulangerie.Models;
using System.Collections.Generic;
using System;

namespace Boulangerie.Tests
{
  [TestClass]
  public class PastryTest
  {
   
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void PastryPrice_CalculatesPastryPrice_Int()
    {
      Pastry newPastry = new Pastry();
      newPastry.AddItems(1);
      // newPastry.Pastry();
      Assert.AreEqual(2, newPastry.Price);

    }

     [TestMethod]
    public void PastryCalculator_CalculatesPastryOrders_Int()
    {
      Pastry newPastry = new Pastry();
      newPastry.AddItems(5);// this AddItems method is borrowed from the parent class. It is necessary to include because it contains parameters, and gives the CalculateOrder method an argument to multiply.
      newPastry.CalculateOrder(); // this CalculateOrder comes from the Pastry class, and requires no parameter. 
      Assert.AreEqual(8, newPastry.TotalPrice);

    }

  }
}
   
   
    