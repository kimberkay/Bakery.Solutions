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
      if (Quantity <= 3 & Quantity % 3 == 0)
      {
        Price = (Quantity * 5) - ((Quantity/3)*5); 
        return Price;
      }
      else if (Quantity > 4 & Price % 3 > 0)
      { 
       Price = ((Quantity * 5) - (Quantity / 3 *5)); 
        return Price;
      }
      else
      {
          return Price;
      }
    }   
  }    
}
