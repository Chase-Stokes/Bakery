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
      return BasePrice;
    }

  }
}