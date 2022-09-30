using System.Collections.Generic;

namespace Vendor.Models
{
  public class Order
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public int Days { get; set; }// currently days from now, can later change to c# DateTime thingy
    public int Id {get; }
    private static List<Order> _instances = new List<Order> { };
 

    // public Order(string description)
    // {
    //   Description = description;
    //   _instances.Add(this);
    //   Id = _instances.Count;
    // }

    public Order(string name, string description, int price, int days)
    {
      Name = name;
      Description = description;
      Price = price;
      Days = days;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}