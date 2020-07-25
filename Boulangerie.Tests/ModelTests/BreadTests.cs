using Microsoft.VisualStudio.TestTools.UnitTesting;
using Boulangerie.Models;
using System.Collections.Generic;
using System;

namespace Boulangerie.Tests
{
  [TestClass]

  public class BoulangerieTest : IDisposable
  {

    public void Dispose()
    {
      Boulangerie.ClearAll();
    }

    [TestMethod]
    public void ItemConstructor_CreatesInstancesOfItem_Item()
    {
      Item newItem = new Item("test Item");
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }


    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread("test Bread");
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry("test Pastry");
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
  }
}