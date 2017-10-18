using System.Collections.Generic;
using System;

namespace RockPaperScissors.Models
{

  public class Game
  {
    private string _name;
    private string _play;
    private static List<Game> _games = new List<Game> {};

    public Game(string name, string play)
    {
      _name = name;
      _play = play;
      _games.Add(this);
    }

    public string GetPlayerName()
    {
      return _name;
    }
    public string GetPlayerPlay()
    {
      return _play;
    }

    public static List<Game> GetGames()
    {
      return _games;
    }
    // public static ComparePlay()
    // {
    //  string Player1Play = _games[0].GetPlayerPlay();
    //  string Player2Play = _games[1].GetPlayerPlay();
    //  if (Player1Play == Player2Play)
    //  {
    //    return "Draw";
    //  }
    //  if (Player1Play == "Rock")
    //  {
    //    if (Player2Play == "Scissors")
    //    {
    //      return "Player 1 Wins";
    //    }
    //    else if (Player2Play == "Paper")
    //    {
    //      return "Player 2 Wins";
    //    }
    //  }
    //  if (Player1Play == "Paper")
    //  {
    //    if (Player2Play == "Rock")
    //    {
    //      return "Player 1 Wins";
    //    }
    //    else if (Player2Play == "Scissors")
    //    {
    //      return "Player 2 Wins";
    //    }
    //  }
    //  if (Player1Play == "Scissors")
    //  {
    //    if (Player2Play == "Paper")
    //    {
    //      return "Player 1 Wins";
    //    }
    //    else if (Player2Play == "Rock")
    //    {
    //      return "Player 2 Wins";
    //    }
    //  }
    //
    // }

  }
}
