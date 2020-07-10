using grimtolSummer20.Project.Interfaces;

namespace grimtolSummer20.Project.Models
{
  public class Player : IPlayer
  {
    public string Name { get; set; }
    public Player(string name)
    {
      Name = name;
    }
  }
}