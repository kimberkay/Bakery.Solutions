using System;


namespace Bakery.Models
{
  
  public class Pastry
  {
    public int PastryQuantity { get; set; }
    public int PastryPrice { get; set; }

    public Pastry(int pastryQuantity, int pastryPrice)
    {
      PastryQuantity = pastryQuantity;
      PastryPrice = pastryPrice;
    }

    public int PastryTotal()
    {    
      if (PastryQuantity == 3)
      {
        PastryPrice = 5;
        return PastryPrice;
      }
      else if (PastryQuantity > 3 & PastryQuantity % 3 > 0)
      { 
       PastryPrice = ((PastryQuantity * 2) - (PastryQuantity/3)); 
        return PastryPrice;
      }
      else
      {
          return PastryPrice;
      }
    } 

    public string Pastries()
    {
      if (PastryQuantity > 1)
      {
        return "pastries";
      }
      else
      {
        return "pastry";
      }
    }  
  }  
} 