using Microsoft.VisualStudio.TestTools.UnitTesting;
using Boulangerie.Models;

namespace Boulangerie.Tests
{
  [TestClass]
  public class PastryTest
  {
    
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(2);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

  }
}
   
   
    