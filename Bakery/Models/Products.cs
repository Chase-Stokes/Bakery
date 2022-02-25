namespace Products
{
  public class Bread
  {
    public int Loaves {get; set;}
    private static int BasePrice = 5;
    public Bread(int loaves)
    {
      Loaves = loaves;
    }

    public static int CostForBread(int breadAmount)
    {
      if (breadAmount >= 3)
      {
        breadAmount = (breadAmount/3)*2+ breadAmount%3;
      }
      int breadCost = (breadAmount * 5);

      return breadCost;
    }

  }
}