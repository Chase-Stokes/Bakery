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
      List<string> _breadList = new List<string> {};

      Assert.AreEqual(typeof(List<string>), _breadList.GetType());
    }
    
    [TestMethod]
    public void OrderPastry_CreatesPastryList_PastryList()
    {
      List<string> _pastryList = Order.OrderPastry();

      Assert.AreEqual(typeof(List<string>), _pastryList.GetType());
    }
  }
}