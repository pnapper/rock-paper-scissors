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
    public static string ComparePlay()
    {
     string Player1Play = _games[0].GetPlayerPlay();
     string Player2Play = _games[1].GetPlayerPlay();
     string result = "game on";

     if (Player1Play == Player2Play)
     {
       result = "Draw";
     }
     if (Player1Play == "Rock")
     {
       if (Player2Play == "Scissors")
       {
         result = "Player 1 Wins";
       }
       else if (Player2Play == "Paper")
       {
         result = "Player 2 Wins";
       }
     }
     if (Player1Play == "Paper")
     {
       if (Player2Play == "Rock")
       {
         result = "Player 1 Wins";
       }
       else if (Player2Play == "Scissors")
       {
         result = "Player 2 Wins";
       }
     }
     if (Player1Play == "Scissors")
     {
       if (Player2Play == "Paper")
       {
         result = "Player 1 Wins";
       }
       else if (Player2Play == "Rock")
       {
         result = "Player 2 Wins";
       }
     }
     return result;
    }
    public static void ClearAll()
    {
      _games.Clear();
    }
  }
}
