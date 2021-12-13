using System;
using System.Collections.Generic;
using Bakery.Models;

public class Program
{

  public static void Main()
    {
      Console.WriteLine("--------------------------------------------------");  
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("You are in for real treat :)");
      Console.WriteLine("Bread is $5 per loaf or buy 2 and get one free");
      Console.WriteLine("Pastries are $2 per pastry, or $5 for 3");
      Console.WriteLine("-------------------------------------------------- ");
      Console.WriteLine("How many loaves of bread would you like?");
      string breadInput = Console.ReadLine();
      int Quantity = int.Parse(breadInput);
      int Price = 5;
      int PastryPrice = 2;
      Console.WriteLine("How many pastries would you like?");
      string pastryInput = Console.ReadLine();
      int PastryQuantity = int.Parse(pastryInput);
      Console.WriteLine("---------------------------------------------------");
      Console.WriteLine("Your Order:");
      Bread addBread = new Bread(Quantity, Price);
      Pastry addPastry = new Pastry(PastryQuantity, PastryPrice);
      Console.WriteLine(addBread.Quantity + " " + addBread.Loaf() + " of bread and " + addPastry.PastryQuantity + " " + addPastry.Pastries());
      Console.WriteLine("----------------------------------------------------");
      Console.WriteLine("Your Total for today is:");
      Console.WriteLine("-  $" + (addBread.BreadPrice() + addPastry.PastryTotal()) + ".00  -" );
      Console.WriteLine("----------------------------------------------------");
    
     




      
      
    }
  } 