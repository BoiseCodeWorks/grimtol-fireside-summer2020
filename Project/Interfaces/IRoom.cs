using System.Collections.Generic;

namespace grimtolSummer20.Project.Interfaces
{
  public interface IRoom
  {
    string Name { get; set; }
    string Description { get; set; }
    // List<IItem> Items { get; set; }
    Dictionary<string, IRoom> Exits { get; set; }

    string GetTemplate();

    IRoom Move(string x);
    void AddRoomConnection(IRoom room, string direction);

  }
}
