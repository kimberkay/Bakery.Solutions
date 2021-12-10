using System.Collections.Generic;


namespace Bakery.Models
{
  
  public class Bread
  {
    public int Quantity { get; set; }
    public int Price { get; set; }

    public Bread(int qty, int price)
    {
      Quantity = qty;
      Price = price;
    }

    public int BreadPrice()
    {    
      if (Quantity == 0)
      {
        return Price = 0;
      }
      else
      {
        return 0;
      }
      
    }    
  }
}