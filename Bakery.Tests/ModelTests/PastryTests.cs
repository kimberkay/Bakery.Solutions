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

    [TestMethod]
    public void PastryPrice_ReturnPriceOfPastry_Int()
    {
      Pastry addPastry0 = new Pastry(0,0);
      Pastry addPastry1 = new Pastry(1,2);
      Pastry addPastry2 = new Pastry(2,4);
      Pastry addPastry3 = new Pastry(3,5);
      Pastry addPastry4 = new Pastry(4,7);
      Pastry addPastry5 = new Pastry(5,9);
      Pastry addPastry6 = new Pastry(24, 40);
      Assert.AreEqual(0, addPastry0.PastryPrice());
      Assert.AreEqual(2, addPastry1.PastryPrice());
      Assert.AreEqual(4, addPastry2.PastryPrice());
      Assert.AreEqual(5, addPastry3.PastryPrice());
      Assert.AreEqual(7, addPastry4.PastryPrice());
      Assert.AreEqual(9, addPastry5.PastryPrice());
    }     
  }  
}  