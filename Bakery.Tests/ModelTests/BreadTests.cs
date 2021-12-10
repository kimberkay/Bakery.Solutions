using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;


namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {

    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread addBread = new Bread(1,5);
      Assert.AreEqual(typeof(Bread), addBread.GetType());
    }

    [TestMethod]
    public void BreadPrice_ReturnPriceOfBread_Int()
    {
      Bread addBread1 = new Bread(1,5);
      Bread addBread2 = new Bread(2,10);
      Bread addBread3 = new Bread(3, 10);
      Assert.AreEqual(addBread1, 5);
      Assert.AreEqual(addBread2, 10);
      Assert.AreEqual(addBread3, 10);
    }
  }
}