using System.Collections.Generic;

namespace Vendor.Models
{
  public class Distributor
  {
    private static List<Distributor> _instances = new List<Distributor> {};
    public string Name { get; set; }
    public int Id { get; }
    //public List<Order> Orders { get; set; }

    public Distributor(string vendorName)
    {
      Name = vendorName;
      _instances.Add(this);
      Id = _instances.Count;
      //Orders = new List<Order>{};
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  //   public static List<Artist> GetAll()
  //   {
  //     return _instances;
  //   }

  //   public static Artist Find(int searchId)
  //   {
  //     return _instances[searchId-1];
  //   }

  //   public void AddAlbum(Album album)
  // {
  //   Albums.Add(album);
  // }

  }
}