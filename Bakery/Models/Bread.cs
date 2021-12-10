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
      int Price = Quantity * 5;
      if (Price % 3 == 0)
      {
        Price = (Quantity % 2 +1) * 5;
      }

      }
      
    }    
  }
}