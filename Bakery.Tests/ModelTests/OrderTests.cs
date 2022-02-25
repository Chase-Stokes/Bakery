using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    
    [TestMethod]
    public void Order_ChecksBreadProperty_1()
    {
      Order newOrder = new Order(1,2);
      Assert.AreEqual(1, newOrder.Bread);
    }
   
    [TestMethod]
    public void Order_ChecksPastryProperty_2()
    {
      Order newOrder = new Order(1,2);
      Assert.AreEqual(2, newOrder.Pastry);
    }
  }
}