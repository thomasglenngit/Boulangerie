using Microsoft.VisualStudio.TestTools.UnitTesting;
using Boulangerie.Models;
using System.Collections.Generic;
using System;

namespace Boulangerie.Tests
{
  [TestClass]

  public class ItemTest
  {
    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item(1, 1, 1);
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }

    [TestMethod]
    public void AddItems_AddsNumberOfItemsInputByUser_Int()
    {

      
      Item newItem = new Item();
      int result = newItem.AddItems(1);

      Assert.AreEqual(result, newItem.AddItems();
    }

  }
}