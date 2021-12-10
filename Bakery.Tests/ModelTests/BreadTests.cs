using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;

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
    public void BreadPrice_ReturnsBreadPriceAndQuantity_Int();
    {
      
      Bread addBread = new Bread(1,5);
      Assert.AreEqual(1, Bread.BreadPrice(5));
    }
  }
}