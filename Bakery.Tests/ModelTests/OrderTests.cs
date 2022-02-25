using System;
using System.Collections.Generic;
using BakeryOrder;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Order.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderBread_CreatesBreadList_BreadList()
    {
      List<string> breadList = new List<string> {};

      Assert.AreEqual(typeof(List<>), breadList.GetType());
    }
  }
}