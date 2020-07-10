using System.Collections.Generic;
using grimtolSummer20.Project.Interfaces;

namespace grimtolSummer20.Project.Models
{
  public class Room : IRoom
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public Dictionary<string, IRoom> Exits { get; set; }

    public Room(string name, string description)
    {
      this.Name = name;
      this.Description = description;
      Exits = new Dictionary<string, IRoom>();
    }

    public void AddRoomConnection(IRoom room, string direction)
    {
      Exits.Add(direction, room);
    }

    public string GetTemplate()
    {
      string template = $"You are in the {Name} \n {Description} \nYou have exits to your \n";

      string connections = "";
      foreach (var room in Exits)
      {
        connections += room.Key + "  ";
      }
      return template += connections;
    }

    public IRoom Move(string x)
    {
      if (Exits.ContainsKey(x))
      {
        return Exits[x];
      }
      return this;
    }

  }
}