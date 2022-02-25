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
  }
}