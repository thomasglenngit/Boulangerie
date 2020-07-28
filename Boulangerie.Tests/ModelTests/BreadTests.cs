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
      Pastry newPastry = new Pastry();
      newPastry.AddItems();
      Assert.AreEqual(newPastry.Price);
    }

  }
}