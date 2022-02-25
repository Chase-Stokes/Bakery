using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryOrder;

namespace BakeryOrder.TestsTools
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void Order_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order(1,2);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}