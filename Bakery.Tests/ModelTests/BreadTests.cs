using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
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

    public void CalculateBreadPrice_ReturnsPriceOfBread_Int();
    {
      int breadCount = 1;
      Bread testBread = new Bread(1,5);
      Assert.AreEqual(typeof(Bread), testBread.BreadPrice(5));
    }


  }
}