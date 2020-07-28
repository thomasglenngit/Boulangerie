using Microsoft.VisualStudio.TestTools.UnitTesting;
using Boulangerie.Models;
using System.Collections.Generic;
using System;

namespace Boulangerie.Tests
{
  [TestClass]

  public class BreadTest
  {

    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    public void BreadPrice_CalculatesBreadPrice_Int()
    {
      Bread newBread = new Bread();
      newBread.AddItems(1);
      Assert.AreEqual(5, newBread.Price);
    }

    [TestMethod]
    public void BreadQuantity_VerifyQuantityValue_Int()
    {
      Bread newBread = new Bread();
      newBread.AddItems(100000);
      Assert.AreEqual(100000, newBread.Quantity);
    }

    [TestMethod]
    public void BreadCalculator_CalculatesBreadOrders_Int()
    {
      Bread newBread = new Bread();
      newBread.AddItems(20);
      newBread.CalculateOrder();
      Assert.AreEqual(95, newBread.TotalPrice);
    }

  }
}