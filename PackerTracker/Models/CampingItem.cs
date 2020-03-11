using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class CampingItem
  {
    public string Item { get; set; }
    public string Price { get; set; }
    public string Weight { get; set; }
    public int Id { get; set; }
    public string Name { get; set; }
    private static List<CampingItem> _instances = new List<CampingItem> {};

    public CampingItem(string item, string price, string weight, string name)
    {
      Item = item;
      Price = price;
      Weight = weight;
      Name = name;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static List<CampingItem> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static CampingItem Find(int searchId)
    {
      return _instances[searchId -1];
    }
  }
}