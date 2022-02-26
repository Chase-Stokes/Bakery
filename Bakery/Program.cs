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
      Console.WriteLine("Thank you for shopping with us!  Type anything to continue..}");
      Console.WriteLine("To leave at anytime.   type:{EXIT}");
      string input = Console.ReadLine();
      int pastryAmount = 0;
      int breadAmount = 0;
      while(input != "EXIT")
      {
        Console.WriteLine("Would you like some pastries, bread, or directions to the door?    type:{pastry/bread/leave}");
        input = Console.ReadLine();
        if (input.ToLower() == "pastry")
        {
          Console.WriteLine("Enter amount of pastries: ");
          pastryAmount += int.Parse(Console.ReadLine());
        }
        else if (input.ToLower() == "bread")
        {
          Console.WriteLine("How many loaves of bread would you like: ");
          breadAmount += int.Parse(Console.ReadLine());
        }
        else if (input.ToLower() == "leave")
        {
        Order user = new Order(breadAmount, pastryAmount);
        Bread breadOrder= new Bread(user.Bread);
        Pastry pastryOrder = new Pastry(user.Pastry);
        int breadCost = Bread.CostForBread(breadOrder.Loaves);
        int pastryCost = Pastry.CostForPastries(pastryOrder.Pastries);
        int total = breadCost + pastryCost;
        Console.WriteLine("Your total is $"+total);
        Console.WriteLine("Thank you for coming in!");
        input = "EXIT";
        }
      }
    }
  }
}

