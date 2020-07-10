using grimtolSummer20.Project.Interfaces;

namespace grimtolSummer20.Project.Models
{
  public class Game : IGame
  {
    public IRoom CurrentRoom { get; set; }
    public IPlayer CurrentPlayer { get; set; }

    public void Setup()
    {
      System.Console.WriteLine("Game Setup");
      IRoom start = new Room("Teaching Room", "It has a projector in it");
      CurrentRoom = start;
      IRoom two = new Room("Lobby", "It is downstairs");
      start.AddRoomConnection(two, "south");
      two.AddRoomConnection(start, "north");
      IRoom three = new TrapRoom("The Parking Lot", "A car falls out of the sky and lands on you.");
      two.AddRoomConnection(three, "south");
    }
    public Game()
    {
      CurrentPlayer = new Player("");
      Setup();
    }
  }
}