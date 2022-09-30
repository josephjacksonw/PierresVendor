using System.Collections.Generic;

namespace Vendor.Models
{
  public class Distributor
  {
    private static List<Distributor> _instances = new List<Distributor> {};
    public string Name { get; set; } // Company name
    public string Description { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }

    public Distributor(string vendorName, string description)
    {
      Name = vendorName;
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order>{};
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Distributor> GetAll()
    {
      return _instances;
    }

    public static Distributor Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public void AddOrder(Order order)
  {
    Orders.Add(order);
  }
  }
}