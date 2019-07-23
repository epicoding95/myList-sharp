using System;
using System.Collections.Generic;


namespace ToDoList
{
  public class Item
  {
    public string Description { get; set; }
    private static List<Item> _instances = new List<Item> {};

    public Item(string description)
    {
      Description = description;
      _instances.Add(this);
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      // _instances.Clear();
    }


  }
}

// Item itemInstance = new Item(){}
// itemInstance._instances


// Item._instances;
// Item.GetAll()