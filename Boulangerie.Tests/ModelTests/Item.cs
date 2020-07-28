using Microsoft.VisualStudio.TestTools.UnitTesting;
using Boulangerie.Models;
using System.Collections.Generic;
using System;

namespace Boulangerie.Tests
{
  public class ItemTest
  {

    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item();
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }

    [TestMethod]
    public void AddItems_VerifiesQuantityOfAddedItems_Int()
    {
      Item newItem = new Item();
      newItem.AddItems();
      Assert.AreEqual(newItem.Quantity);
    }
  }
}