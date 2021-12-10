using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;


namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry addPastry = new Pastry(1,2);
      Assert.AreEqual(typeof(Pastry), addPastry.GetType());
    }
  }  
}  