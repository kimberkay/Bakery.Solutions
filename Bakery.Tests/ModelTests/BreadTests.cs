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

    public void BreadPrice_ReturnBreadPrice_Int();
    {
      int breadInput = 1;
      Bread testBread = new Bread(1,5);
    }


  }
}