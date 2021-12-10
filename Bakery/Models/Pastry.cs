using System;


namespace Bakery.Models
{
  
  public class Pastry
  {
    public int Quantity { get; set; }
    public int Price { get; set; }

    public Pastry(int qty, int price)
    {
      Quantity = qty;
      Price = price;
    }
  }  
}  