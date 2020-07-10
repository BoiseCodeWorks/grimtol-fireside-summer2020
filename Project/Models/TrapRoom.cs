using System.Collections.Generic;
using grimtolSummer20.Project.Interfaces;

namespace grimtolSummer20.Project.Models
{
  public class TrapRoom : IRoom
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public Dictionary<string, IRoom> Exits { get; set; }

    public void AddRoomConnection(IRoom room, string direction)
    {
      Exits.Add(direction, room);

    }
    public TrapRoom(string name, string description)
    {
      this.Name = name;
      this.Description = description;
      Exits = new Dictionary<string, IRoom>();
    }
    public string GetTemplate()
    {
      return @$"
You run into the {Name} and {Description}

    You Die";


    }

    public IRoom Move(string x)
    {
      throw new System.NotImplementedException();
    }
  }
}