using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Products.TestsTools
{
  [TestClass]

  public class BreadTests
  {
    [TestMethod]

    public void Bread_ChecksLoavesProperty_1()
    {
      Bread breadOrder = new Bread(1);
      Assert.AreEqual(1, breadOrder.Loaves);
    }
    
    [TestMethod]

    public void CostForBread_ChecksForDiscount_10()
    {
      Bread breadOrder = new Bread(3);
      Assert.AreEqual(10, Bread.CostForBread(breadOrder.Loaves));
    }
  }

  [TestClass]

  public class PastryTests
  {
    [TestMethod]

    public void Pastry_ChecksPastriesProperty_1()
    {
      Pastry pastryOrder = new Pastry(1);
      Assert.AreEqual(1, pastryOrder.Pastries);
    }

    [TestMethod]

    public void CostForPastries_ChecksForPastryDiscount_10()
    {
      Pastry pastryOrder = new Pastry(6);
      Assert.AreEqual(10, Pastry.CostForPastries(pastryOrder.Pastries));
    }

  }
}