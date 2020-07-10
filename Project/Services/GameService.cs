using System;
using System.Collections.Generic;
using grimtolSummer20.Project.Interfaces;
using grimtolSummer20.Project.Models;

namespace grimtolSummer20.Project
{
  public class GameService : IGameService
  {
    private IGame _game { get; set; } = new Game();
    public List<string> Messages { get; set; } = new List<string>();

    public void Go(string direction)
    {
      string from = _game.CurrentRoom.Name;
      _game.CurrentRoom = _game.CurrentRoom.Move(direction);
      string to = _game.CurrentRoom.Name;
      if (to == from)
      {
        Messages.Add("You cannot travel to this location");
        Look();
        return;
      }
      Messages.Add($"Traveled to {to} from {from}");
      Look();
    }

    public void Help()
    {
      throw new NotImplementedException();
    }

    public void Inventory()
    {
      throw new NotImplementedException();
    }

    public void Look()
    {
      Messages.Add(_game.CurrentPlayer.Name + "'s Adventure \n" + _game.CurrentRoom.GetTemplate());
    }

    public void Quit()
    {
      throw new NotImplementedException();
    }

    public void Reset()
    {
      throw new NotImplementedException();
    }

    public void Setup(string playerName)
    {
      _game.CurrentPlayer.Name = playerName;
    }

    public void TakeItem(string itemName)
    {
      throw new NotImplementedException();
    }

    public void UseItem(string itemName)
    {
      throw new NotImplementedException();
    }
  }
}