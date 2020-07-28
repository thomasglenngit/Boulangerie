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
      Assert.AreEqual(2, newPastry.Price);
    }

    [TestMethod]
    public void PastryQuantity_VerifyQuantityValue_Int()
    {
      Pastry newPastry = new Pastry();
      newPastry.AddItems()
      Assert.AreEqual(newPastry.Quantity);
    }

     [TestMethod]
    public void PastryCalculator_CalculatesPastryOrders_Int()
    {
      Pastry newPastry = new Pastry();
      newPastry.AddItems(9);// this AddItems method is borrowed from the parent class. It is necessary to include because it contains parameters, and gives the CalculateOrder method an argument to multiply.
      newPastry.CalculateOrder(); // this CalculateOrder comes from the Pastry class, and requires no parameter, but...
      Assert.AreEqual(16, newPastry.TotalPrice); // this assertion includes the inherited property (Item => Pastry) "TotalPrice" used in the Pastry CalculateOrder() method.

    }

  }
}
   
   
    