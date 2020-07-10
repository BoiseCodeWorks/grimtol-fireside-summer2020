using System;
using System.Collections.Generic;
using grimtolSummer20.Project.Interfaces;

namespace grimtolSummer20.Project.Controllers
{

  public class GameController : IGameController
  {
    private GameService _gs = new GameService();
    public void GetUserInput()
    {
      Console.WriteLine("What would ya like to do");
      string input = Console.ReadLine().ToLower() + " ";
      string command = input.Substring(0, input.IndexOf(" "));
      string option = input.Substring(input.IndexOf(" ") + 1).Trim();

      switch (command)
      {
        case "l":
          _gs.Look();
          break;
        case "go":
          _gs.Go(option);
          break;
      }
    }

    public void Run()
    {
      System.Console.WriteLine("Game running");
      System.Console.WriteLine("What is your name brave adventurer?");
      string pName = Console.ReadLine();
      // Console.Clear();
      _gs.Setup(pName);
      _gs.Look();
      Print();
      while (true)
      {
        GetUserInput();
        Print();
      }
    }

    private void Print()
    {
      foreach (string m in _gs.Messages)
      {
        Console.WriteLine(m);
      }
      _gs.Messages.Clear();
    }
  }
}