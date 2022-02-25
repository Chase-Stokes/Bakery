// Prompt User with a welcome message
// Prompt User with the cost for both bread and pastry
// Prompt User with the deals the bakery offers

using System;
using BakeryOrder;
using Products;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierres Bakery.");
      Console.WriteLine("~~~~~~~~~~~~~~~~~~");
      Console.WriteLine("We have specials today!");
      Console.WriteLine("~~~~~~~~~~~~~~~~~~");
      Console.WriteLine("Bread is BUY TWO GET ONE FREE!");
      Console.WriteLine("~~~~~~~~~~~~~~~~~~");
      Console.WriteLine("Pastries are 1 for $2 or 3 for $5!");
      Console.WriteLine("~~~~~~~~~~~~~~~~~~");
      Console.WriteLine("~~~~~~~~~~~~~~~~~~");
      Console.WriteLine("Would you like some pastries or bread?    type:{pastry/bread}");
      Console.WriteLine("To leave at anytime.   type:{EXIT}");
      string input = Console.ReadLine();
      while(input != "EXIT" || input != null)
      {
        int pastryAmount = 0;
        int breadAmount = 0;
        if (input.ToLower() == "pastry")
        {
          Console.WriteLine("Enter an amount of pastries, or type :{bread/pay} to order bread or checkout.");
          if (Console.ReadLine().ToLower() == "bread")
          {
            input = "bread";
          }
          else if (Console.ReadLine().ToLower() == "pay")
          {
            input = "pay";
          }
          else 
          {
            pastryAmount = int.Parse(Console.ReadLine());
          }
        }
        else if (input.ToLower() == "bread")
        {
          Console.WriteLine("Enter an amount of loaves, or type :{bread/pay} to order bread or checkout.");
          if (Console.ReadLine().ToLower() == "pastry")
          {
            input = "pastry";
          }
          else if (Console.ReadLine().ToLower() == "pay")
          {
            input = "pay";
          }
          else 
          {
            breadAmount = int.Parse(Console.ReadLine());
          }
        }
        else if (input.ToLower() == "pay")
        {
        Order user = new Order(breadAmount, pastryAmount);
        Bread breadOrder= new Bread(user.Bread);
        Pastry pastryOrder = new Pastry(user.Pastry);
        int breadCost = Bread.CostForBread(breadOrder.Loaves);
        int pastryCost = Pastry.CostForPastries(pastryOrder.Pastries);
        int total = breadCost + pastryCost;
        Console.WriteLine("Your total is $"+total);
        Console.WriteLine("Thank you for shopping with us!");
        input = "EXIT";
        }
      }
    }
  }
}

