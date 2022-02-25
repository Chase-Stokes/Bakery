using System.Collections.Generic;
using System;

namespace BakeryOrder
{
  public class Order
  {
    private static List<string> _breadList = new List<string>{};
    public static List<string> OrderBread(string input)
    {
      return _breadList;
    }
  }
}