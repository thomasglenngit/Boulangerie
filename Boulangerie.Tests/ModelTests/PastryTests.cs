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

    // [TestMethod]
    // public void PastryCalculator_CalculatesPastryOrders_Int()
    // {
    //   Pastry newPastry = new Pastry();
    //   newPastry.CalculateOrder();

    // }

  }
}
   
   
    