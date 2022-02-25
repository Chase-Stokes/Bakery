using System;

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
        breadAmount = (breadAmount/3) * 2+ breadAmount % 3;
      }
      int breadCost = (breadAmount * 5);

      return breadCost;
    }
  }

  public class Pastry
  {
    public int Pastries {get; set;}

    public Pastry(int pastries)
    {
      Pastries = pastries;
    }

    public static int CostForPastries(int pastryAmount)
    {
      int discountForThree = (pastryAmount/3) * 5;
      int leftOver = (pastryAmount%3) * 2;
      int pastryCost = discountForThree + leftOver;
      return pastryCost;
    }
  }
}
//Pastry: Buy 1 for $2 or 3 for $5. Four pastries costs $7, five pastries costs $9, and six pastries costs $10.